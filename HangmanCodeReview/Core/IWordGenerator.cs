using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Core
{
    public interface IWordGenerator
    {
        public string GetRandomWord(int difficulty);
    }
}
