using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace proiect
{
    public class database_ops
    {
        SqlConnection con;

        public database_ops()
        {
            this.con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mihaela\Desktop\II - Industrial Informatics\proiect\Database1.mdf;Integrated Security=True";
        }


        public void add_client(string nume, string prenume, string cnp, string username, string password, string telefon, string adresa)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"insert into client (nume, prenume, cnp, username, password, telefon, adresa) values (@nume, @prenume, @cnp, @username, @password, @telefon, @adresa)";

            cmd.Parameters.AddWithValue("@nume", nume);
            cmd.Parameters.AddWithValue("@prenume", prenume);
            cmd.Parameters.AddWithValue("@cnp", cnp);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@telefon", telefon);
            cmd.Parameters.AddWithValue("@adresa", adresa);

            // hash the password
            byte[] hash;
            using (HashAlgorithm algorithm = SHA256.Create())
                hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder hashed_passwd = new StringBuilder();
            foreach (byte b in hash)
                hashed_passwd.Append(b.ToString("X2"));

            cmd.Parameters.AddWithValue("@password", hashed_passwd.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataSet get_products()
        {
            DataSet prod = new DataSet();

            con.Open();
            SqlDataAdapter da_prod = new SqlDataAdapter("select * from produs", con);
            da_prod.Fill(prod, "produs");
            con.Close();

            return prod;
        }

        public DataSet get_users()
        {
            DataSet users = new DataSet();

            con.Open();
            SqlDataAdapter da_users = new SqlDataAdapter("select * from client", con);
            da_users.Fill(users, "client");
            con.Close();

            return users;
        }

        public DataSet get_orders()
        {
            DataSet orders = new DataSet();

            con.Open();
            SqlDataAdapter da_orders = new SqlDataAdapter("select comanda.id, comanda.id_prod, comanda.id_client, produs.nume, " +
                "produs.pret, client.id, client.nume, client.adresa from comanda, produs, client " +
                "where comanda.id_prod=produs.id and comanda.id_client=client.id", con);
            da_orders.Fill(orders);
            con.Close();

            return orders;
        }

        public void add_product(string name, int price, string type, string pic_path)
        {
            con.Open();

            var cmd = con.CreateCommand();

            cmd.CommandText = @"insert into produs (nume, pret, tip, poza) values (@name, @price, @type, @pic_path)";
            
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@type", type);
            Console.WriteLine(pic_path);

            cmd.Parameters.AddWithValue("@pic_path", pic_path);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                //item not added :(

            }
            con.Close();
        }

        public void add_order(int id_prod, int id_client)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"insert into comanda (id_prod, id_client) values (@id_prod, @id_client)";
            cmd.Parameters.AddWithValue("@id_prod", id_prod);
            cmd.Parameters.AddWithValue("@id_client", id_client);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // order not placed :(
            }

            con.Close();
        }

        public void deliver_order(int prod_id)
        {
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"update comanda set state='delivered' where id=@prod_id";
            cmd.Parameters.AddWithValue("@prod_id", prod_id);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            con.Close();
        }


        public DataSet get_orders_by_id(int id)
        {
            DataSet orders = new DataSet();

            con.Open();
            SqlDataAdapter da_orders = new SqlDataAdapter("select comanda.id, comanda.id_prod, comanda.id_client, produs.nume, " +
                "produs.pret, client.id, client.nume, client.adresa, comanda.state from comanda, produs, client " +
                "where comanda.id_prod=produs.id and comanda.id_client=client.id and client.id="+id, con);

            da_orders.Fill(orders);
            con.Close();

            return orders;
        }
    }
}
