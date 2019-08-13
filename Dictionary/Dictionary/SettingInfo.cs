namespace Dictionary
{
    /// <summary>
    /// .iniファイル取得時の格納クラス
    /// </summary>
    class SettingInfo
    {
        /// <summary>
        /// アプリ名
        /// </summary>
        public string ApplicationName { get; set; }

        /// <summary>
        /// 追加予定辞書データ格納先
        /// </summary>
        public string AddItemDirectory { get; set; }

        /// <summary>
        /// 辞書データ格納先
        /// </summary>
        public string DictionaryInfoDirectory { get; set; }

        /// <summary>
        /// 処理に失敗した辞書データ格納先
        /// </summary>
        public string DictionartErrInfoDirectory { get; set; }

        /// <summary>
        /// 処理を行うファイルを一時格納する
        /// </summary>
        public string TempDirectory { get; set; }

        /// <summary>
        /// エラー情報格納先
        /// </summary>
        public string ErrorInfoDirectory { get; set; }

        /// <summary>
        /// ログデータ格納先
        /// </summary>
        public string LogInfoDirectory { get; set; }
    }
}
