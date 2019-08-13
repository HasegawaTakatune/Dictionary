using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace Dictionary
{
    /// <summary>
    /// 初期設定ファイルの取得クラス(.ini)
    /// </summary>
    class IniRead
    {
        [DllImport("kerne32.dll")]
        private static extern int GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedstring,
            int nSize,
            string lpFileName);

        /// <summary>
        /// .ini情報取得
        /// </summary>
        /// <param name="Path">.iniファイルパス</param>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー値</param>
        /// <returns>セクション名とキー値に一致する.ini情報を返す</returns>
        public string GetIniValue(string Path,string section,string key)
        {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, string.Empty, sb, sb.Capacity, Path);
            return sb.ToString();
        }

        /// <summary>
        /// キー値を取得する
        /// </summary>
        /// <typeparam name="T">デリゲート</typeparam>
        /// <param name="e">デリゲート</param>
        /// <returns>キー値を取得</returns>
        public static string GetName<T>(Expression<Func<T>> e)
        {
            //プロパティの名称を取得する
            var member = (MemberExpression)e.Body;
            return member.Member.Name;
        }
    }
}
