/* TrieWithOneChild.cs
 * Author: Brett Montgomery
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        private bool _containsEmptyString;
        private ITrie _child;
        private char _childLabel;

        /// <summary>
        /// constructor for a trie with one child
        /// </summary>
        /// <param name="s">string being tested for</param>
        /// <param name="_contains">whether the child already exists</param>
        /// <param name="_childLabel">the child label</param>
        /// <param name="_child">the child itself</param>
        public TrieWithOneChild(string s, bool _contains)
        {
            if (s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            _containsEmptyString = _contains;
            _childLabel = s[0];
            _child = new TrieWithNoChildren().Add(s.Substring(1));
        }

        /// <summary>
        /// adds a string to the current trie
        /// </summary>
        /// <param name="s">string being added</param>
        /// <returns></returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _containsEmptyString = true;
                return this;
            }
            else if (s[0] == _childLabel)
            {
                _child = _child.Add(s.Substring(1));
                return this;
            }
            else
            {
                return new TrieWithManyChildren(s, _containsEmptyString, _childLabel, _child);
            }
        }

        /// <summary>
        /// checks to see if the trie contains the current string
        /// </summary>
        /// <param name="s">string being tsted for</param>
        /// <returns>whether the trie contains the string</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _containsEmptyString;
            }
            else if (s[0] == _childLabel)
            {
                return _child.Contains(s.Substring(1));
            }
            else
            {
                return false;
            }
        }
    }
}