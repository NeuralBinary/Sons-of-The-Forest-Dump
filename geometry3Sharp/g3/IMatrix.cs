using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000325 RID: 805
	[Token(Token = "0x2000325")]
	public interface IMatrix
	{
		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001B20 RID: 6944
		[Token(Token = "0x1700040C")]
		int Rows { [Token(Token = "0x6001B20")] get; }

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001B21 RID: 6945
		[Token(Token = "0x1700040D")]
		int Columns { [Token(Token = "0x6001B21")] get; }

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001B22 RID: 6946
		[Token(Token = "0x1700040E")]
		Index2i Size { [Token(Token = "0x6001B22")] get; }

		// Token: 0x06001B23 RID: 6947
		[Token(Token = "0x6001B23")]
		void Set(int r, int c, double value);

		// Token: 0x1700040F RID: 1039
		[Token(Token = "0x1700040F")]
		double this[int r, int c]
		{
			[Token(Token = "0x6001B24")]
			get;
			[Token(Token = "0x6001B25")]
			set;
		}
	}
}
