using System;
using System.IO;
using System.Text;

namespace Base64Tool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string historyFilePath = "Base64_History.txt";

            while (true)
            {
                Console.Clear(); // 清空屏幕 / Clear screen
                Console.WriteLine("=========================");
                Console.WriteLine(" Base64 編碼工具 / Tool ");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Base64 編碼 / Encode");
                Console.WriteLine("2. Base64 解碼 / Decode");
                Console.WriteLine("0. 退出 / Exit");
                Console.WriteLine("=========================");
                Console.Write("請選擇 (0-2) / Please select (0-2): ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("程序已退出 / Program exited.");
                    break;
                }

                switch (choice)
                {
                    case "1":
                        while (true)
                        {
                            Console.Write("\n請輸入要編碼的字符串 / Enter a string to encode (輸入 'b' 返回主選單 / type 'b' to return): ");
                            string inputToEncode = Console.ReadLine();

                            // 檢查輸入是否為空 / Check if input is empty
                            if (string.IsNullOrWhiteSpace(inputToEncode))
                            {
                                Console.WriteLine();
                                Console.WriteLine("輸入內容不可為空，請重試 / Input cannot be empty. Please try again.");
                                continue;
                            }

                            // 返回主選單 / Return to main menu
                            if (inputToEncode.ToLower() == "b") break;

                            string encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(inputToEncode));
                            SaveToHistory(historyFilePath, "Encoded", inputToEncode, encoded);
                            Console.WriteLine("\n=========================");
                            Console.WriteLine("Base64 編碼 / Encoded:");
                            Console.WriteLine(encoded);
                            Console.WriteLine("=========================");

                        }
                        break;

                    case "2":
                        while (true)
                        {
                            Console.Write("\n請輸入要解碼的Base64字符串 / Enter a Base64 string to decode (輸入 'b' 返回主選單 / type 'b' to return): ");
                            string inputToDecode = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(inputToDecode))
                            {
                                Console.WriteLine();
                                Console.WriteLine("輸入內容不可為空，請重試 / Input cannot be empty. Please try again.");
                                continue;
                            }

                            // 返回主選單 / Return to main menu
                            if (inputToDecode.ToLower() == "b") break;

                            // 檢查Base64字符串長度是否有效 / Check if the length of Base64 string is valid
                            if (inputToDecode.Length % 4 != 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("輸入的Base64字符串長度無效，請確認 / Invalid Base64 string length. Please check your input.");
                               continue;
                            }

                            try
                            {
                                string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(inputToDecode));
                                SaveToHistory(historyFilePath, "Decoded", inputToDecode, decoded);
                                Console.WriteLine("\n=========================");
                                Console.WriteLine("解碼後的字符串 / Decoded string:");
                                Console.WriteLine(decoded);
                                Console.WriteLine("=========================");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine();
                                Console.WriteLine("無效的Base64字符串 / Invalid Base64 string.");
                                continue;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("無效選項，請重試 / Invalid choice, please try again.");
                        break;
                }
            }
        }

        /// <summary>
        /// 保存操作歷史紀錄到檔案 / Save operation history to file.
        /// </summary>
        /// <param name="filePath">檔案路徑 / File path.</param>
        /// <param name="operation">操作類型 (編碼或解碼) / Operation type (Encode or Decode).</param>
        /// <param name="input">用戶輸入 / User input.</param>
        /// <param name="result">操作結果 / Operation result.</param>
        private static void SaveToHistory(string filePath, string operation, string input, string result)
        {
            // 存到桌面 / Save to desktop
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), filePath);

            string history = $"[{DateTime.Now}] {operation}:\nInput: {input}\nResult: {result}\n";
            File.AppendAllText(filePath, history);
            Console.WriteLine($"\n操作已保存到 {filePath} / Operation saved to {filePath}");
        }
    }
}
