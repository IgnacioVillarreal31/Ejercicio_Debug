//-------------------------------------------------------------------------
// <copyright file="Word.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

namespace WordsPhrases
{
    public class Word
    {
        private string text;

        public Word(string text)
        {
            this.Text = text;
        }

        public string Text
        {
            get
            {
                return this.text;
            }

            set
            {
                this.text = value.Trim();
            }
        }
    }
}
