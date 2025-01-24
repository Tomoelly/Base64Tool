# Base64Tool

## Overview
`Base64Tool` is a simple console application for encoding and decoding Base64 strings. The tool allows you to:

- Encode any input string to Base64 format.
- Decode any valid Base64 string back to its original format.
- Save operation history to a file on your desktop for future reference.

## Features
- **Encode**: Convert a plain text string to Base64 format.
- **Decode**: Convert a Base64 string back to plain text.
- **History**: Saves all encoding and decoding operations to a file (`Base64_History.txt`) on your desktop.

## How to Use
1. Run the application.
2. Select an option from the main menu:
   - `1`: Encode a string to Base64.
   - `2`: Decode a Base64 string.
   - `0`: Exit the program.
3. Follow the prompts to input your string and view the result.

### Returning to the Main Menu
- During encoding or decoding, you can type `b` to return to the main menu.

## Example Usage
### Encoding
- Input: `hello`
- Output: `aGVsbG8=`

### Decoding
- Input: `aGVsbG8=`
- Output: `hello`

### Return to Menu
- Input: `b`
- Action: Returns to the main menu.

## File History
All operations are logged in a file named `Base64_History.txt`, located on your desktop. Each record includes:
- Timestamp of the operation.
- Type of operation (Encode or Decode).
- Input string.
- Result.

### Example Log
```
[2025-01-24 15:30:00] Encoded:
Input: hello
Result: aGVsbG8=

[2025-01-24 15:32:00] Decoded:
Input: aGVsbG8=
Result: hello
```

## Prerequisites
- .NET runtime installed on your system.

## Installation
1. Clone or download this repository.
2. Open the project in Visual Studio or your preferred IDE.
3. Build and run the project.

## Contribution
Feel free to contribute to this project by submitting pull requests or issues.

## License
This project is licensed under the MIT License. See the `LICENSE` file for details.

---

# Base64Tool

## 概述
`Base64Tool` 是一個簡單的控制台應用程式，用於 Base64 字符串的編碼與解碼。該工具允許您：

- 將任何輸入字符串編碼為 Base64 格式。
- 將有效的 Base64 字符串解碼為原始格式。
- 將操作歷史記錄保存到桌面上的檔案中以供日後參考。

## 功能
- **編碼**：將純文本字符串轉換為 Base64 格式。
- **解碼**：將 Base64 字符串轉換回純文本。
- **歷史記錄**：將所有編碼和解碼操作保存到桌面上的檔案（`Base64_History.txt`）。

## 使用方法
1. 執行應用程式。
2. 從主選單中選擇一個選項：
   - `1`：編碼字符串為 Base64。
   - `2`：解碼 Base64 字符串。
   - `0`：退出程式。
3. 按提示輸入字符串並查看結果。

### 返回主選單
- 在編碼或解碼過程中，您可以輸入 `b` 返回主選單。

## 使用範例
### 編碼
- 輸入：`hello`
- 輸出：`aGVsbG8=`

### 解碼
- 輸入：`aGVsbG8=`
- 輸出：`hello`

### 返回主選單
- 輸入：`b`
- 行動：返回主選單。

## 檔案歷史記錄
所有操作都會記錄在桌面上的名為 `Base64_History.txt` 的檔案中。每條記錄包含：
- 操作的時間戳。
- 操作類型（編碼或解碼）。
- 輸入字符串。
- 結果。

### 範例日誌
```
[2025-01-24 15:30:00] Encoded:
Input: hello
Result: aGVsbG8=

[2025-01-24 15:32:00] Decoded:
Input: aGVsbG8=
Result: hello
```

## 系統需求
- 已安裝 .NET 運行時。

## 安裝
1. 克隆或下載此專案。
2. 在 Visual Studio 或您偏好的 IDE 中打開該專案。
3. 編譯並執行專案。

## 貢獻
歡迎通過提交 Pull Request 或 Issues 為該專案做出貢獻。

## 授權
此專案基於 MIT 授權進行分發。詳情請參見 `LICENSE` 檔案。
