using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;

namespace Dictionary
{
    /// <summary>
    /// アプリの基本ステータス
    /// </summary>
    public sealed class ApplicationStatus
    {

        /// <summary>
        /// 初期設定ファイル
        /// </summary>
        private const string COMMON = "common.ini";

        /// <summary>
        /// 設定情報クラス
        /// </summary>
        SettingInfo setting;

        /// <summary>
        /// アプリステータスのインスタンス生成
        /// </summary>
        private static readonly ApplicationStatus _applicationStatus = new ApplicationStatus();

        /// <summary>
        /// インスタンス取得
        /// </summary>
        /// <returns></returns>
        public static ApplicationStatus GetInstance()
        {
            return _applicationStatus;
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private ApplicationStatus()
        {
            const string SECTION = "INFO";
            try
            {

                setting = new SettingInfo();

                setting.ApplicationName = GetIniValue(COMMON, SECTION, GetName(() => setting.ApplicationName));
                //if (string.IsNullOrEmpty(setting.ApplicationName)) throw new Exception("アプリケーション名が設定されていません。");

                setting.AddItemDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.AddItemDirectory));
                System.IO.File.Exists(setting.AddItemDirectory);

                setting.DictionaryInfoDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.DictionaryInfoDirectory));

                setting.DictionartErrInfoDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.DictionartErrInfoDirectory));

                setting.TempDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.TempDirectory));

                setting.ErrorInfoDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.ErrorInfoDirectory));

                setting.LogInfoDirectory = GetIniValue(COMMON, SECTION, GetName(() => setting.LogInfoDirectory));

            }
            catch (Exception e)
            {
                Logger.ErrLog(e.Message);
            }
        }




        /**********************************************************************/
        /****  .ini取得処理                ************************************/
        /**********************************************************************/

        /// <summary>
        /// ラップされている.iniファイル取得処理
        /// </summary>
        /// <param name="lpApplicationName">セクション名</param>
        /// <param name="lpKeyName">キー値</param>
        /// <param name="lpDefault">取得できない場合の戻り値</param>
        /// <param name="lpReturnedString">取得値の格納先</param>
        /// <param name="nSize">サイズ</param>
        /// <param name="lpFileName">ファイル名</param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern uint GetPrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        [DllImport("kernel32.dll")]
        public static extern uint
        GetPrivateProfileInt(
        string lpAppName,
        string lpKeyName,
        int nDefault,
        string lpFileName);

        [DllImport("kernel32.dll")]
        private static extern uint WritePrivateProfileString(
            string lpApplicationName,
            string lpKeyName,
            string lpstring,
            string lpFileName);

        /// <summary>
        /// .ini情報取得
        /// </summary>
        /// <param name="path">.iniファイルパス</param>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー値</param>
        /// <returns>セクション名とキー値に一致する.ini情報を返す</returns>
        public string GetIniValue(string path, string section, string key)
        {
            StringBuilder sb = new StringBuilder(256);
            GetPrivateProfileString(section, key, string.Empty, sb, Convert.ToUInt32 (sb.Capacity), path);
            return sb.ToString();
        }

        /// <summary>
        /// .ini情報取得
        /// </summary>
        /// <param name="path">.iniファイルパス</param>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー値</param>
        /// <returns>セクション名とキー値に一致する.ini情報を返す</returns>
        public int getValueInt(string path, string section, string key)
        {
            return (int)GetPrivateProfileInt(section, key, 0, path);
        }

        /// <summary>
        /// .ini情報設定
        /// </summary>
        /// <param name="path">.iniファイルパス</param>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー値</param>
        /// <param name="val">設定値</param>
        public void SetValue(string path, string section, string key, int val)
        {
            SetValue(path,section, key, val.ToString());
        }

        /// <summary>
        /// .ini情報設定
        /// </summary>
        /// <param name="path">.iniファイルパス</param>
        /// <param name="section">セクション名</param>
        /// <param name="key">キー値</param>
        /// <param name="val">設定値</param>
        public void SetValue(string path, string section, string key, string val)
        {
            WritePrivateProfileString(section, key, val, path);
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