using System;

namespace SAE_Squelette
{
    public class CommentaireMission
    {
        private string commentaire;

        public CommentaireMission(string commentaire)
        {
            this.Commentaire = commentaire;
        }

        public string Commentaire
        {
            get
            {
                return this.commentaire;
            }

            set
            {
                this.commentaire = value;
            }
        }

        public CommentaireMission(object commentaire)
        {
            throw new System.NotImplementedException("Not implemented");
        }
    }
}