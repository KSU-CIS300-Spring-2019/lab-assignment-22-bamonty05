/* ITrie.cs
 * Author: Brett Montgomery
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public interface ITrie
    {
        /// <summary>
        /// add method call
        /// </summary>
        /// <param name="s"></param>
        /// <returns>the new trie</returns>
        ITrie Add(string s);

        /// <summary>
        /// conatins method call
        /// </summary>
        /// <param name="s">string being looked forstring being added</param>
        /// <returns>whether the trie contains the string</returns>
        bool Contains(string s);
    }
}
