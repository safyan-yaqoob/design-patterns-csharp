using System;
using System.Collections.Generic;
using System.Text;

namespace Mediater_Pattern
{
    public class ArticleDialogBox 
    {
        private ListBox ArticlesListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        public ArticleDialogBox()
        {
            ArticlesListBox.Attach(this.articleSelected());
        }

        private void articleSelected()
        {
            titleTextBox.content = ArticlesListBox.selection;
        }
    }
}
