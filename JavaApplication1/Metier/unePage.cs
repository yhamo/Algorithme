using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Librairie MySQL ajoutée dans les références.
using MySql.Data.MySqlClient;

namespace Metier
{
    public class unePage
    {
        #region Déclaration des variables + Setter / Getter + Constructeurs
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private DateTime dateGmt;
        public DateTime DateGmt
        {
            get { return dateGmt; }
            set { dateGmt = value; }
        }

        private string content;
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private string excerpt;
        public string Excerpt
        {
            get { return excerpt; }
            set { excerpt = value; }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string commentStatus;
        public string CommentStatus
        {
            get { return commentStatus; }
            set { commentStatus = value; }
        }

        private string pingStatus;
        public string PingStatus
        {
            get { return pingStatus; }
            set { pingStatus = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string toPing;
        public string ToPing
        {
            get { return toPing; }
            set { toPing = value; }
        }

        private string pinged;
        public string Pinged
        {
            get { return pinged; }
            set { pinged = value; }
        }

        private DateTime modified;
        public DateTime Modified
        {
            get { return modified; }
            set { modified = value; }
        }

        private DateTime modifiedGtm;
        public DateTime ModifiedGtm
        {
            get { return modifiedGtm; }
            set { modifiedGtm = value; }
        }

        private string contentFiltered;
        public string ContentFiltered
        {
            get { return contentFiltered; }
            set { contentFiltered = value; }
        }

        private string parent;
        public string Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private string guid;
        public string Guid
        {
            get { return guid; }
            set { guid = value; }
        }

        private int menuOrder;
        public int MenuOrder
        {
            get { return menuOrder; }
            set { menuOrder = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string mineType;
        public string MineType
        {
            get { return mineType; }
            set { mineType = value; }
        }

        private string count;
        public string Count
        {
            get { return count; }
            set { count = value; }
        }

        public unePage()
        {

        }

        public unePage (int unId, string unAuthor, DateTime uneDate, DateTime uneDateGmt, string unContent, string unTitle, string unExcerpt, 
            string unStatus, string unPassword, string unName, string unPing, string unPinged, DateTime uneModified, DateTime uneModifiedGtm, 
            string unParent, string unGuid, int unMenuOrder, string unType, string unMineType, string unCount)
        {
            this.id = unId;
            this.author = unAuthor;
            this.date = uneDate;
            this.dateGmt = uneDateGmt;
            this.content = unContent;
            this.title = unTitle;
            this.excerpt = unExcerpt;
            this.status = unStatus;
            this.password = unPassword;
            this.name = unName;
            this.toPing = unPing;
            this.pinged = unPinged;
            this.modified = uneModified;
            this.modifiedGtm = uneModifiedGtm;
            this.parent = unParent;
            this.guid = unGuid;
            this.menuOrder = unMenuOrder;
            this.type = unType;
            this.mineType = unMineType;
            this.count = unCount;
        }

        #endregion
    }
}
