using System;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonTextWriter : JsonWriter
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2524400", Offset = "0x2522A00", VA = "0x182524400", Slot = "6")]
		public override Task FlushAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2524580", Offset = "0x2522B80", VA = "0x182524580")]
		internal Task DoFlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2524640", Offset = "0x2522C40", VA = "0x182524640", Slot = "9")]
		protected override Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x25247A0", Offset = "0x2522DA0", VA = "0x1825247A0")]
		internal Task DoWriteValueDelimiterAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2524870", Offset = "0x2522E70", VA = "0x182524870", Slot = "7")]
		protected override Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2524AA0", Offset = "0x25230A0", VA = "0x182524AA0")]
		internal Task DoWriteEndAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2524BE0", Offset = "0x25231E0", VA = "0x182524BE0", Slot = "5")]
		public override Task CloseAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2524CB0", Offset = "0x25232B0", VA = "0x182524CB0")]
		internal Task DoCloseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2524E90", Offset = "0x2523490", VA = "0x182524E90")]
		private Task CloseBufferAndWriterAsync()
		{
			return null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2525000", Offset = "0x2523600", VA = "0x182525000", Slot = "12")]
		public override Task WriteEndAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x25251F0", Offset = "0x25237F0", VA = "0x1825251F0", Slot = "8")]
		protected override Task WriteIndentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x25253B0", Offset = "0x25239B0", VA = "0x1825253B0")]
		internal Task DoWriteIndentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x25254B0", Offset = "0x2523AB0", VA = "0x1825254B0")]
		private Task WriteIndentAsync(int currentIndentCount, int newLineLen, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x25256C0", Offset = "0x2523CC0", VA = "0x1825256C0")]
		private Task WriteValueInternalAsync(JsonToken token, string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x2525790", Offset = "0x2523D90", VA = "0x182525790")]
		private Task WriteValueInternalAsync(Task task, string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x2525A30", Offset = "0x2524030", VA = "0x182525A30", Slot = "10")]
		protected override Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x2525B90", Offset = "0x2524190", VA = "0x182525B90")]
		internal Task DoWriteIndentSpaceAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x2525C60", Offset = "0x2524260", VA = "0x182525C60", Slot = "11")]
		public override Task WriteRawAsync([Nullable(2)] string json, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x2525DD0", Offset = "0x25243D0", VA = "0x182525DD0")]
		internal Task DoWriteRawAsync([Nullable(2)] string json, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x2525EB0", Offset = "0x25244B0", VA = "0x182525EB0", Slot = "16")]
		public override Task WriteNullAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x2525FD0", Offset = "0x25245D0", VA = "0x182525FD0")]
		internal Task DoWriteNullAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x2526050", Offset = "0x2524650", VA = "0x182526050")]
		private Task WriteDigitsAsync(ulong uvalue, bool negative, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x2526140", Offset = "0x2524740", VA = "0x182526140")]
		private Task WriteIntegerValueAsync(ulong uvalue, bool negative, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x2526210", Offset = "0x2524810", VA = "0x182526210")]
		private Task WriteIntegerValueAsync(Task task, ulong uvalue, bool negative, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x2526470", Offset = "0x2524A70", VA = "0x182526470")]
		internal Task WriteIntegerValueAsync(long value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x25264B0", Offset = "0x2524AB0", VA = "0x1825264B0")]
		internal Task WriteIntegerValueAsync(ulong uvalue, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x25264D0", Offset = "0x2524AD0", VA = "0x1825264D0")]
		private Task WriteEscapedStringAsync(string value, bool quote, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x25266C0", Offset = "0x2524CC0", VA = "0x1825266C0", Slot = "17")]
		public override Task WritePropertyNameAsync(string name, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x25268F0", Offset = "0x2524EF0", VA = "0x1825268F0")]
		internal Task DoWritePropertyNameAsync(string name, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x2526A40", Offset = "0x2525040", VA = "0x182526A40")]
		private Task DoWritePropertyNameAsync(Task task, string name, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x2526CE0", Offset = "0x25252E0", VA = "0x182526CE0", Slot = "18")]
		public override Task WritePropertyNameAsync(string name, bool escape, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x2526DD0", Offset = "0x25253D0", VA = "0x182526DD0")]
		internal Task DoWritePropertyNameAsync(string name, bool escape, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x2527030", Offset = "0x2525630", VA = "0x182527030", Slot = "19")]
		public override Task WriteStartArrayAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x2527220", Offset = "0x2525820", VA = "0x182527220")]
		internal Task DoWriteStartArrayAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x2527360", Offset = "0x2525960", VA = "0x182527360")]
		internal Task DoWriteStartArrayAsync(Task task, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x25275A0", Offset = "0x2525BA0", VA = "0x1825275A0", Slot = "23")]
		public override Task WriteStartObjectAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x2527790", Offset = "0x2525D90", VA = "0x182527790")]
		internal Task DoWriteStartObjectAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x25278D0", Offset = "0x2525ED0", VA = "0x1825278D0")]
		internal Task DoWriteStartObjectAsync(Task task, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x2527B10", Offset = "0x2526110", VA = "0x182527B10", Slot = "22")]
		public override Task WriteStartConstructorAsync(string name, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x2527C00", Offset = "0x2526200", VA = "0x182527C00")]
		internal Task DoWriteStartConstructorAsync(string name, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x2527E40", Offset = "0x2526440", VA = "0x182527E40", Slot = "63")]
		public override Task WriteUndefinedAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x2527FF0", Offset = "0x25265F0", VA = "0x182527FF0")]
		internal Task DoWriteUndefinedAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x25280F0", Offset = "0x25266F0", VA = "0x1825280F0")]
		private Task DoWriteUndefinedAsync(Task task, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x2528330", Offset = "0x2526930", VA = "0x182528330", Slot = "64")]
		public override Task WriteWhitespaceAsync(string ws, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x25284B0", Offset = "0x2526AB0", VA = "0x1825284B0")]
		internal Task DoWriteWhitespaceAsync(string ws, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x25285A0", Offset = "0x2526BA0", VA = "0x1825285A0", Slot = "25")]
		public override Task WriteValueAsync(bool value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2528690", Offset = "0x2526C90", VA = "0x182528690")]
		internal Task DoWriteValueAsync(bool value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2528710", Offset = "0x2526D10", VA = "0x182528710", Slot = "26")]
		public override Task WriteValueAsync(bool? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2528850", Offset = "0x2526E50", VA = "0x182528850")]
		internal Task DoWriteValueAsync(bool? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x25288E0", Offset = "0x2526EE0", VA = "0x1825288E0", Slot = "27")]
		public override Task WriteValueAsync(byte value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x25289E0", Offset = "0x2526FE0", VA = "0x1825289E0", Slot = "28")]
		public override Task WriteValueAsync(byte? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x2528B30", Offset = "0x2527130", VA = "0x182528B30")]
		internal Task DoWriteValueAsync(byte? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2528BC0", Offset = "0x25271C0", VA = "0x182528BC0", Slot = "29")]
		public override Task WriteValueAsync([Nullable(2)] byte[] value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x2528CD0", Offset = "0x25272D0", VA = "0x182528CD0")]
		internal Task WriteValueNonNullAsync(byte[] value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2528F10", Offset = "0x2527510", VA = "0x182528F10", Slot = "30")]
		public override Task WriteValueAsync(char value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2529000", Offset = "0x2527600", VA = "0x182529000")]
		internal Task DoWriteValueAsync(char value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2529080", Offset = "0x2527680", VA = "0x182529080", Slot = "31")]
		public override Task WriteValueAsync(char? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x25291C0", Offset = "0x25277C0", VA = "0x1825291C0")]
		internal Task DoWriteValueAsync(char? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2529250", Offset = "0x2527850", VA = "0x182529250", Slot = "32")]
		public override Task WriteValueAsync(DateTime value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2529340", Offset = "0x2527940", VA = "0x182529340")]
		internal Task DoWriteValueAsync(DateTime value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x2529540", Offset = "0x2527B40", VA = "0x182529540", Slot = "33")]
		public override Task WriteValueAsync(DateTime? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x2529690", Offset = "0x2527C90", VA = "0x182529690")]
		internal Task DoWriteValueAsync(DateTime? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2529710", Offset = "0x2527D10", VA = "0x182529710", Slot = "34")]
		public override Task WriteValueAsync(DateTimeOffset value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x2529810", Offset = "0x2527E10", VA = "0x182529810")]
		internal Task DoWriteValueAsync(DateTimeOffset value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2529A20", Offset = "0x2528020", VA = "0x182529A20", Slot = "35")]
		public override Task WriteValueAsync(DateTimeOffset? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2529B90", Offset = "0x2528190", VA = "0x182529B90")]
		internal Task DoWriteValueAsync(DateTimeOffset? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2529C20", Offset = "0x2528220", VA = "0x182529C20", Slot = "36")]
		public override Task WriteValueAsync(decimal value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x2529D70", Offset = "0x2528370", VA = "0x182529D70")]
		internal Task DoWriteValueAsync(decimal value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2529E00", Offset = "0x2528400", VA = "0x182529E00", Slot = "37")]
		public override Task WriteValueAsync(decimal? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x2529FC0", Offset = "0x25285C0", VA = "0x182529FC0")]
		internal Task DoWriteValueAsync(decimal? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x252A0A0", Offset = "0x25286A0", VA = "0x18252A0A0", Slot = "38")]
		public override Task WriteValueAsync(double value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x252A190", Offset = "0x2528790", VA = "0x18252A190")]
		internal Task WriteValueAsync(double value, bool nullable, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x252A250", Offset = "0x2528850", VA = "0x18252A250", Slot = "39")]
		public override Task WriteValueAsync(double? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x252A3B0", Offset = "0x25289B0", VA = "0x18252A3B0", Slot = "40")]
		public override Task WriteValueAsync(float value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x252A4A0", Offset = "0x2528AA0", VA = "0x18252A4A0")]
		internal Task WriteValueAsync(float value, bool nullable, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x252A560", Offset = "0x2528B60", VA = "0x18252A560", Slot = "41")]
		public override Task WriteValueAsync(float? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x252A6B0", Offset = "0x2528CB0", VA = "0x18252A6B0", Slot = "42")]
		public override Task WriteValueAsync(Guid value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x252A7B0", Offset = "0x2528DB0", VA = "0x18252A7B0")]
		internal Task DoWriteValueAsync(Guid value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x252A9C0", Offset = "0x2528FC0", VA = "0x18252A9C0", Slot = "43")]
		public override Task WriteValueAsync(Guid? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x252AB30", Offset = "0x2529130", VA = "0x18252AB30")]
		internal Task DoWriteValueAsync(Guid? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x252ABC0", Offset = "0x25291C0", VA = "0x18252ABC0", Slot = "44")]
		public override Task WriteValueAsync(int value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x252ACD0", Offset = "0x25292D0", VA = "0x18252ACD0", Slot = "45")]
		public override Task WriteValueAsync(int? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x252AE30", Offset = "0x2529430", VA = "0x18252AE30")]
		internal Task DoWriteValueAsync(int? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x252AEE0", Offset = "0x25294E0", VA = "0x18252AEE0", Slot = "46")]
		public override Task WriteValueAsync(long value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x252AFE0", Offset = "0x25295E0", VA = "0x18252AFE0", Slot = "47")]
		public override Task WriteValueAsync(long? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x252B150", Offset = "0x2529750", VA = "0x18252B150")]
		internal Task DoWriteValueAsync(long? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x252B200", Offset = "0x2529800", VA = "0x18252B200")]
		internal Task WriteValueAsync(BigInteger value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x252B2D0", Offset = "0x25298D0", VA = "0x18252B2D0", Slot = "48")]
		public override Task WriteValueAsync([Nullable(2)] object value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x252B570", Offset = "0x2529B70", VA = "0x18252B570", Slot = "49")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(sbyte value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x252B680", Offset = "0x2529C80", VA = "0x18252B680", Slot = "50")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(sbyte? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x252B7E0", Offset = "0x2529DE0", VA = "0x18252B7E0")]
		internal Task DoWriteValueAsync(sbyte? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x252B890", Offset = "0x2529E90", VA = "0x18252B890", Slot = "51")]
		public override Task WriteValueAsync(short value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x252B9A0", Offset = "0x2529FA0", VA = "0x18252B9A0", Slot = "52")]
		public override Task WriteValueAsync(short? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x252BB00", Offset = "0x252A100", VA = "0x18252BB00")]
		internal Task DoWriteValueAsync(short? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x252BBB0", Offset = "0x252A1B0", VA = "0x18252BBB0", Slot = "53")]
		public override Task WriteValueAsync([Nullable(2)] string value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x252BDB0", Offset = "0x252A3B0", VA = "0x18252BDB0")]
		internal Task DoWriteValueAsync([Nullable(2)] string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x252BEE0", Offset = "0x252A4E0", VA = "0x18252BEE0")]
		private Task DoWriteValueAsync(Task task, [Nullable(2)] string value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x252C180", Offset = "0x252A780", VA = "0x18252C180", Slot = "54")]
		public override Task WriteValueAsync(TimeSpan value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x252C270", Offset = "0x252A870", VA = "0x18252C270")]
		internal Task DoWriteValueAsync(TimeSpan value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x252C470", Offset = "0x252AA70", VA = "0x18252C470", Slot = "55")]
		public override Task WriteValueAsync(TimeSpan? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x252C5C0", Offset = "0x252ABC0", VA = "0x18252C5C0")]
		internal Task DoWriteValueAsync(TimeSpan? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x252C640", Offset = "0x252AC40", VA = "0x18252C640", Slot = "56")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(uint value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x252C730", Offset = "0x252AD30", VA = "0x18252C730", Slot = "57")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(uint? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x252C880", Offset = "0x252AE80", VA = "0x18252C880")]
		internal Task DoWriteValueAsync(uint? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x252C910", Offset = "0x252AF10", VA = "0x18252C910", Slot = "58")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(ulong value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x252CA00", Offset = "0x252B000", VA = "0x18252CA00", Slot = "59")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(ulong? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x252CB60", Offset = "0x252B160", VA = "0x18252CB60")]
		internal Task DoWriteValueAsync(ulong? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x252CBF0", Offset = "0x252B1F0", VA = "0x18252CBF0", Slot = "60")]
		public override Task WriteValueAsync([Nullable(2)] Uri value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x252CDE0", Offset = "0x252B3E0", VA = "0x18252CDE0")]
		internal Task WriteValueNotNullAsync(Uri value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x252CEC0", Offset = "0x252B4C0", VA = "0x18252CEC0")]
		internal Task WriteValueNotNullAsync(Task task, Uri value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x252D160", Offset = "0x252B760", VA = "0x18252D160", Slot = "61")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(ushort value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x252D250", Offset = "0x252B850", VA = "0x18252D250", Slot = "62")]
		[CLSCompliant(false)]
		public override Task WriteValueAsync(ushort? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x252D390", Offset = "0x252B990", VA = "0x18252D390")]
		internal Task DoWriteValueAsync(ushort? value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x252D420", Offset = "0x252BA20", VA = "0x18252D420", Slot = "20")]
		public override Task WriteCommentAsync([Nullable(2)] string text, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x252D510", Offset = "0x252BB10", VA = "0x18252D510")]
		internal Task DoWriteCommentAsync([Nullable(2)] string text, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x252D750", Offset = "0x252BD50", VA = "0x18252D750", Slot = "13")]
		public override Task WriteEndArrayAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x252D820", Offset = "0x252BE20", VA = "0x18252D820", Slot = "14")]
		public override Task WriteEndConstructorAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x252D8F0", Offset = "0x252BEF0", VA = "0x18252D8F0", Slot = "15")]
		public override Task WriteEndObjectAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x252D9C0", Offset = "0x252BFC0", VA = "0x18252D9C0", Slot = "21")]
		public override Task WriteRawValueAsync([Nullable(2)] string json, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x252DB50", Offset = "0x252C150", VA = "0x18252DB50")]
		internal Task DoWriteRawValueAsync([Nullable(2)] string json, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x252DC20", Offset = "0x252C220", VA = "0x18252DC20")]
		private Task DoWriteRawValueAsync(Task task, [Nullable(2)] string json, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x252DEC0", Offset = "0x252C4C0", VA = "0x18252DEC0")]
		internal char[] EnsureWriteBuffer(int length, int copyTo)
		{
			return null;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000084")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x252E1A0", Offset = "0x252C7A0", VA = "0x18252E1A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		[Nullable(2)]
		public IArrayPool<char> ArrayPool
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x252E3A0", Offset = "0x252C9A0", VA = "0x18252E3A0")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public int Indentation
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x252E450", Offset = "0x252CA50", VA = "0x18252E450")]
			set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00002D30 File Offset: 0x00000F30
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public char QuoteChar
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x252E4C0", Offset = "0x252CAC0", VA = "0x18252E4C0")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x252E4D0", Offset = "0x252CAD0", VA = "0x18252E4D0")]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002D48 File Offset: 0x00000F48
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public char IndentChar
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x252E550", Offset = "0x252CB50", VA = "0x18252E550")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x252E560", Offset = "0x252CB60", VA = "0x18252E560")]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00002D60 File Offset: 0x00000F60
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public bool QuoteName
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x252E5D0", Offset = "0x252CBD0", VA = "0x18252E5D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x252E5E0", Offset = "0x252CBE0", VA = "0x18252E5E0")]
			set
			{
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x252E5F0", Offset = "0x252CBF0", VA = "0x18252E5F0")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x252E780", Offset = "0x252CD80", VA = "0x18252E780", Slot = "66")]
		public override void Flush()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x252E7B0", Offset = "0x252CDB0", VA = "0x18252E7B0", Slot = "67")]
		public override void Close()
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x252E8B0", Offset = "0x252CEB0", VA = "0x18252E8B0")]
		private void CloseBufferAndWriter()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x252E9A0", Offset = "0x252CFA0", VA = "0x18252E9A0", Slot = "68")]
		public override void WriteStartObject()
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x252EA00", Offset = "0x252D000", VA = "0x18252EA00", Slot = "70")]
		public override void WriteStartArray()
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x252EA60", Offset = "0x252D060", VA = "0x18252EA60", Slot = "72")]
		public override void WriteStartConstructor(string name)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x252EB20", Offset = "0x252D120", VA = "0x18252EB20", Slot = "78")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x252EC30", Offset = "0x252D230", VA = "0x18252EC30", Slot = "74")]
		public override void WritePropertyName(string name)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x252ECF0", Offset = "0x252D2F0", VA = "0x18252ECF0", Slot = "75")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x252EE20", Offset = "0x252D420", VA = "0x18252EE20", Slot = "65")]
		internal override void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x252EE30", Offset = "0x252D430", VA = "0x18252EE30")]
		private void UpdateCharEscapeFlags()
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x252EEF0", Offset = "0x252D4F0", VA = "0x18252EEF0", Slot = "79")]
		protected override void WriteIndent()
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x252F050", Offset = "0x252D650", VA = "0x18252F050")]
		private int SetIndentChars()
		{
			return 0;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x252F200", Offset = "0x252D800", VA = "0x18252F200", Slot = "80")]
		protected override void WriteValueDelimiter()
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x252F230", Offset = "0x252D830", VA = "0x18252F230", Slot = "81")]
		protected override void WriteIndentSpace()
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x252F260", Offset = "0x252D860", VA = "0x18252F260")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x252F290", Offset = "0x252D890", VA = "0x18252F290", Slot = "123")]
		[NullableContext(2)]
		public override void WriteValue(object value)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x252F3E0", Offset = "0x252D9E0", VA = "0x18252F3E0", Slot = "82")]
		public override void WriteNull()
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x252F470", Offset = "0x252DA70", VA = "0x18252F470", Slot = "83")]
		public override void WriteUndefined()
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x252F260", Offset = "0x252D860", VA = "0x18252F260", Slot = "84")]
		[NullableContext(2)]
		public override void WriteRaw(string json)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x252F500", Offset = "0x252DB00", VA = "0x18252F500", Slot = "86")]
		[NullableContext(2)]
		public override void WriteValue(string value)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x252F5C0", Offset = "0x252DBC0", VA = "0x18252F5C0")]
		private void WriteEscapedString(string value, bool quote)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x252F6A0", Offset = "0x252DCA0", VA = "0x18252F6A0", Slot = "87")]
		public override void WriteValue(int value)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x252F780", Offset = "0x252DD80", VA = "0x18252F780", Slot = "88")]
		[CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x252F800", Offset = "0x252DE00", VA = "0x18252F800", Slot = "89")]
		public override void WriteValue(long value)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x252F890", Offset = "0x252DE90", VA = "0x18252F890", Slot = "90")]
		[CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x252F8D0", Offset = "0x252DED0", VA = "0x18252F8D0", Slot = "91")]
		public override void WriteValue(float value)
		{
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x252F990", Offset = "0x252DF90", VA = "0x18252F990", Slot = "108")]
		public override void WriteValue(float? value)
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x252FA90", Offset = "0x252E090", VA = "0x18252FA90", Slot = "92")]
		public override void WriteValue(double value)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x252FB50", Offset = "0x252E150", VA = "0x18252FB50", Slot = "109")]
		public override void WriteValue(double? value)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x252FC50", Offset = "0x252E250", VA = "0x18252FC50", Slot = "93")]
		public override void WriteValue(bool value)
		{
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x252FCF0", Offset = "0x252E2F0", VA = "0x18252FCF0", Slot = "94")]
		public override void WriteValue(short value)
		{
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x252FDD0", Offset = "0x252E3D0", VA = "0x18252FDD0", Slot = "95")]
		[CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x252FE70", Offset = "0x252E470", VA = "0x18252FE70", Slot = "96")]
		public override void WriteValue(char value)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x252FF00", Offset = "0x252E500", VA = "0x18252FF00", Slot = "97")]
		public override void WriteValue(byte value)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x252FFA0", Offset = "0x252E5A0", VA = "0x18252FFA0", Slot = "98")]
		[CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x25300A0", Offset = "0x252E6A0", VA = "0x1825300A0", Slot = "99")]
		public override void WriteValue(decimal value)
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2530140", Offset = "0x252E740", VA = "0x182530140", Slot = "100")]
		public override void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2530300", Offset = "0x252E900", VA = "0x182530300")]
		private int WriteValueToBuffer(DateTime value)
		{
			return 0;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2530440", Offset = "0x252EA40", VA = "0x182530440", Slot = "121")]
		[NullableContext(2)]
		public override void WriteValue(byte[] value)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x25305D0", Offset = "0x252EBD0", VA = "0x1825305D0", Slot = "101")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x2530710", Offset = "0x252ED10", VA = "0x182530710")]
		private int WriteValueToBuffer(DateTimeOffset value)
		{
			return 0;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x2530890", Offset = "0x252EE90", VA = "0x182530890", Slot = "102")]
		public override void WriteValue(Guid value)
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x25309C0", Offset = "0x252EFC0", VA = "0x1825309C0", Slot = "103")]
		public override void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2530B20", Offset = "0x252F120", VA = "0x182530B20", Slot = "122")]
		[NullableContext(2)]
		public override void WriteValue(Uri value)
		{
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2530BD0", Offset = "0x252F1D0", VA = "0x182530BD0", Slot = "124")]
		[NullableContext(2)]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x2530C90", Offset = "0x252F290", VA = "0x182530C90", Slot = "125")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x2530CE0", Offset = "0x252F2E0", VA = "0x182530CE0")]
		private void EnsureWriteBuffer()
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x2530DB0", Offset = "0x252F3B0", VA = "0x182530DB0")]
		private void WriteIntegerValue(long value)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x2530E10", Offset = "0x252F410", VA = "0x182530E10")]
		private void WriteIntegerValue(ulong value, bool negative)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x2530EA0", Offset = "0x252F4A0", VA = "0x182530EA0")]
		private int WriteNumberToBuffer(ulong value, bool negative)
		{
			return 0;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2530FA0", Offset = "0x252F5A0", VA = "0x182530FA0")]
		private void WriteIntegerValue(int value)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2531070", Offset = "0x252F670", VA = "0x182531070")]
		private void WriteIntegerValue(uint value, bool negative)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2531100", Offset = "0x252F700", VA = "0x182531100")]
		private int WriteNumberToBuffer(uint value, bool negative)
		{
			return 0;
		}

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly bool _safeAsync;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		private const int IndentCharBufferSize = 12;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly TextWriter _writer;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Nullable(2)]
		private Base64Encoder _base64Encoder;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private char _indentChar;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _indentation;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private char _quoteChar;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		private bool _quoteName;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Nullable(2)]
		private bool[] _charEscapeFlags;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Nullable(2)]
		private char[] _writeBuffer;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Nullable(2)]
		private IArrayPool<char> _arrayPool;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Nullable(2)]
		private char[] _indentChars;
	}
}
