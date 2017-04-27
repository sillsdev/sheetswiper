# sheetswiper
Sheet Swiper
Sheet Swiper converts spreadsheets containing linguistic data to Standard Format (for use with Linguist's Toolbox, Phonology Assistant, Lexique Pro, FLex, WeSay, etc.). The rules for how to do the conversion come from the first rows of the spreadsheet itself, so subsequent, repeated conversions are easy for non-computer savvy users to do.

##Requirements
Any Microsoft Windows with Microsoft .Net Framework v4.5 or greater.

d
We drag that file in and convert:

![image](https://cloud.githubusercontent.com/assets/8448/25486359/2403ef7a-2b1e-11e7-9ca0-6edb77903279.png)
f
Then "review" tab shows what we'll get:
![image](https://cloud.githubusercontent.com/assets/8448/25486338/11e5b08a-2b1e-11e7-91cb-a84e49613852.png)

##How to use
To use this, make the first row of the spreadsheet contain the sfm markers you want to use for the data in that column. Omit markers from columns you don't want to include in the sfm. The first marker (usually in column A) will be used as the record marker.

Save the file (make sure it is saved as ".xls"), and close it.

Now run Sheet Swiper and use one of its options to locate the file, convert it, and save it. I like to just drag files onto the SheetSwiper? window.

Sheet Swiper can only read .xls spreadsheet format. We have tested Sheet Swiper using Excel XP, 2007, and Open Office's Calc program.

The real work, the reading of the xls, is done via code from [Liu JunFeng's Excel Reader project](https://code.google.com/archive/p/excellibrary/). On Github, this can be found at [fmendes/ExcelDataImport](https://github.com/fmendes/ExcelDataImport/tree/master/ExcelLibrary/Office/Excel) is caring it forward.
