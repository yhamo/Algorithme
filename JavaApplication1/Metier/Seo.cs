using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Seo
    {

        private string meta_id;    
        private string post_id;
        private string meta_key;
        private string meta_value;

        public string Meta_value
        {
            get { return meta_value; }
            set { meta_value = value; }
        }
        public string Meta_key
        {
            get { return meta_key; }
            set { meta_key = value; }
        }

        public string Post_id
        {
            get { return post_id; }
            set { post_id = value; }
        }
        public string Meta_id
        {
            get { return meta_id; }
            set { meta_id = value; }
        }
        public Seo()
        {

        }
        public  Seo (string meta_id,string post_id,string meta_key ,string meta_value)
        {
            this.meta_id = meta_id;
            this.post_id = post_id;
            this.meta_key = meta_key;
            this.meta_value = meta_value;
        }
        

    }
}
