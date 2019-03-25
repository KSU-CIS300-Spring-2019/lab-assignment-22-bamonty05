/* TrieWithNoChildren.cs
 * Author: Brett Montgomery
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {
        private bool _containsEmptyString = false;

        /// <summary>
        /// adds the string to the current trie
        /// </summary>
        /// <param name="s">string being added</param>
        /// <returns>the new trie</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _containsEmptyString = true;
                return this;
            }
            else
            {
                return new TrieWithOneChild(s, _containsEmptyString);
            }
        }

        /// <summary>
        /// tests to see if the string is already contained in the ITrie
        /// </summary>
        /// <param name="s">string being looked for</param>
        /// <returns>whether the ITrie contains the given string or not</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _containsEmptyString;
            }
            else
            {
                return false;
            }
        }
    }
}
