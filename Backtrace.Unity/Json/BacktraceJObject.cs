using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace Backtrace.Unity.Json
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class BacktraceJObject
	{
		// Token: 0x06000306 RID: 774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x765A10", Offset = "0x764010", VA = "0x180765A10")]
		public BacktraceJObject()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x765A20", Offset = "0x764020", VA = "0x180765A20")]
		public BacktraceJObject(IDictionary<string, string> source)
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x765C80", Offset = "0x764280", VA = "0x180765C80")]
		public void Add(string key, bool value)
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x765DA0", Offset = "0x7643A0", VA = "0x180765DA0")]
		public void Add(string key, float value, string format = "G")
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x765EF0", Offset = "0x7644F0", VA = "0x180765EF0")]
		public void Add(string key, double value, string format = "G")
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x766040", Offset = "0x764640", VA = "0x180766040")]
		public void Add(string key, string value)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x766320", Offset = "0x764920", VA = "0x180766320")]
		public void Add(string key, long value)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x766410", Offset = "0x764A10", VA = "0x180766410")]
		public void Add(string key, BacktraceJObject value)
		{
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x7664D0", Offset = "0x764AD0", VA = "0x1807664D0")]
		public void Add(string key, IEnumerable value)
		{
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x766550", Offset = "0x764B50", VA = "0x180766550")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x7665D0", Offset = "0x764BD0", VA = "0x1807665D0")]
		internal void ToJson(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x766680", Offset = "0x764C80", VA = "0x180766680")]
		private void AddUserPrimitives(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x766B90", Offset = "0x765190", VA = "0x180766B90")]
		private void AppendPrimitives(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x766DA0", Offset = "0x7653A0", VA = "0x180766DA0")]
		private void AppendJObjects(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x766FF0", Offset = "0x7655F0", VA = "0x180766FF0")]
		private void AppendComplexValues(StringBuilder stringBuilder)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x767750", Offset = "0x765D50", VA = "0x180767750")]
		private bool ShouldContinueAddingJSONProperties(StringBuilder stringBuilder)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x7677B0", Offset = "0x765DB0", VA = "0x1807677B0")]
		private void AppendKey(string value, StringBuilder builder)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x767A20", Offset = "0x766020", VA = "0x180767A20")]
		private void EscapeString(string value, StringBuilder output)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x767C60", Offset = "0x766260", VA = "0x180767C60")]
		private char IntToHex(int n)
		{
			return '\0';
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x767C70", Offset = "0x766270", VA = "0x180767C70")]
		private void ToCharAsUnicodeToStringBuilder(char c, StringBuilder output)
		{
		}

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Dictionary<string, string> PrimitiveValues;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x18")]
		internal readonly IDictionary<string, string> UserPrimitives;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x20")]
		internal readonly Dictionary<string, BacktraceJObject> InnerObjects;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		internal readonly Dictionary<string, object> ComplexObjects;
	}
}
