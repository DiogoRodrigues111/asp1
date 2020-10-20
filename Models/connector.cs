using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace asp_web_framewrk.Models
{
    public class connector
    {
        public static string cns = "server=localhost;user id=root;password=root;database=sys;allowuservariables=True";
        public static MySqlConnection connection = new MySqlConnection(cns);
        public static MySqlCommand cmd; //  = fix me

        // property
        public static MySqlCommand Propery_Cmd_var
        {
            get { return cmd; }
            set { /* fix me */ }
        }

        public static string Insert_command_sql(string id, string name)
        {
            return "INSERT INTO sys_config(variable, value) VALUES ('" + id + "', '" + name + "')";
        }

        public static MySqlCommand Connectors_verify()
        {
            Connectors_create_command();
            cmd.ExecuteNonQuery();     // err fix me!
            return cmd;
        }

        public static MySqlCommand Connectors_create_command()
        {
            cmd = connection.CreateCommand();
            return cmd;
        }

        public static void Conectors_open()
        {
            connection.Open();
        }

        public static void Conectors_close()
        {
            connection.Close();
        }
    }
}