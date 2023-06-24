using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonWriter : IDisposable
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x253E640", Offset = "0x253CC40", VA = "0x18253E640")]
		internal Task AutoCompleteAsync(JsonToken tokenBeingWritten, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x253E930", Offset = "0x253CF30", VA = "0x18253E930")]
		private Task AutoCompleteAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x253EB10", Offset = "0x253D110", VA = "0x18253EB10", Slot = "5")]
		public virtual Task CloseAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x253EBC0", Offset = "0x253D1C0", VA = "0x18253EBC0", Slot = "6")]
		public virtual Task FlushAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x253EC70", Offset = "0x253D270", VA = "0x18253EC70", Slot = "7")]
		protected virtual Task WriteEndAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x253ED40", Offset = "0x253D340", VA = "0x18253ED40", Slot = "8")]
		protected virtual Task WriteIndentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x253EDF0", Offset = "0x253D3F0", VA = "0x18253EDF0", Slot = "9")]
		protected virtual Task WriteValueDelimiterAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x253EEA0", Offset = "0x253D4A0", VA = "0x18253EEA0", Slot = "10")]
		protected virtual Task WriteIndentSpaceAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x253EF50", Offset = "0x253D550", VA = "0x18253EF50", Slot = "11")]
		public virtual Task WriteRawAsync([Nullable(2)] string json, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x253F020", Offset = "0x253D620", VA = "0x18253F020", Slot = "12")]
		public virtual Task WriteEndAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x253F0D0", Offset = "0x253D6D0", VA = "0x18253F0D0")]
		internal Task WriteEndInternalAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x253F240", Offset = "0x253D840", VA = "0x18253F240")]
		internal Task InternalWriteEndAsync(JsonContainerType type, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x253F490", Offset = "0x253DA90", VA = "0x18253F490", Slot = "13")]
		public virtual Task WriteEndArrayAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x253F540", Offset = "0x253DB40", VA = "0x18253F540", Slot = "14")]
		public virtual Task WriteEndConstructorAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x253F5F0", Offset = "0x253DBF0", VA = "0x18253F5F0", Slot = "15")]
		public virtual Task WriteEndObjectAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x253F6A0", Offset = "0x253DCA0", VA = "0x18253F6A0", Slot = "16")]
		public virtual Task WriteNullAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x253F750", Offset = "0x253DD50", VA = "0x18253F750", Slot = "17")]
		public virtual Task WritePropertyNameAsync(string name, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x253F820", Offset = "0x253DE20", VA = "0x18253F820", Slot = "18")]
		public virtual Task WritePropertyNameAsync(string name, bool escape, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x253F8F0", Offset = "0x253DEF0", VA = "0x18253F8F0")]
		internal Task InternalWritePropertyNameAsync(string name, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x253F9E0", Offset = "0x253DFE0", VA = "0x18253F9E0", Slot = "19")]
		public virtual Task WriteStartArrayAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x253FA90", Offset = "0x253E090", VA = "0x18253FA90")]
		internal Task InternalWriteStartAsync(JsonToken token, JsonContainerType container, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x253FCA0", Offset = "0x253E2A0", VA = "0x18253FCA0", Slot = "20")]
		public virtual Task WriteCommentAsync([Nullable(2)] string text, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x253FD70", Offset = "0x253E370", VA = "0x18253FD70")]
		internal Task InternalWriteCommentAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x253FD80", Offset = "0x253E380", VA = "0x18253FD80", Slot = "21")]
		public virtual Task WriteRawValueAsync([Nullable(2)] string json, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x253FE50", Offset = "0x253E450", VA = "0x18253FE50", Slot = "22")]
		public virtual Task WriteStartConstructorAsync(string name, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x253FF20", Offset = "0x253E520", VA = "0x18253FF20", Slot = "23")]
		public virtual Task WriteStartObjectAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x253FFD0", Offset = "0x253E5D0", VA = "0x18253FFD0")]
		public Task WriteTokenAsync(JsonReader reader, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x25400A0", Offset = "0x253E6A0", VA = "0x1825400A0")]
		public Task WriteTokenAsync(JsonReader reader, bool writeChildren, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2540180", Offset = "0x253E780", VA = "0x182540180")]
		public Task WriteTokenAsync(JsonToken token, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x25401A0", Offset = "0x253E7A0", VA = "0x1825401A0")]
		public Task WriteTokenAsync(JsonToken token, [Nullable(2)] object value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2540BE0", Offset = "0x253F1E0", VA = "0x182540BE0", Slot = "24")]
		internal virtual Task WriteTokenAsync(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2540E40", Offset = "0x253F440", VA = "0x182540E40")]
		internal Task WriteTokenSyncReadingAsync(JsonReader reader, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2541080", Offset = "0x253F680", VA = "0x182541080")]
		private Task WriteConstructorDateAsync(JsonReader reader, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x25412D0", Offset = "0x253F8D0", VA = "0x1825412D0", Slot = "25")]
		public virtual Task WriteValueAsync(bool value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x25413A0", Offset = "0x253F9A0", VA = "0x1825413A0", Slot = "26")]
		public virtual Task WriteValueAsync(bool? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2541470", Offset = "0x253FA70", VA = "0x182541470", Slot = "27")]
		public virtual Task WriteValueAsync(byte value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2541540", Offset = "0x253FB40", VA = "0x182541540", Slot = "28")]
		public virtual Task WriteValueAsync(byte? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2541610", Offset = "0x253FC10", VA = "0x182541610", Slot = "29")]
		public virtual Task WriteValueAsync([Nullable(2)] byte[] value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x25416E0", Offset = "0x253FCE0", VA = "0x1825416E0", Slot = "30")]
		public virtual Task WriteValueAsync(char value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x25417B0", Offset = "0x253FDB0", VA = "0x1825417B0", Slot = "31")]
		public virtual Task WriteValueAsync(char? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2541880", Offset = "0x253FE80", VA = "0x182541880", Slot = "32")]
		public virtual Task WriteValueAsync(DateTime value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2541950", Offset = "0x253FF50", VA = "0x182541950", Slot = "33")]
		public virtual Task WriteValueAsync(DateTime? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2541A20", Offset = "0x2540020", VA = "0x182541A20", Slot = "34")]
		public virtual Task WriteValueAsync(DateTimeOffset value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2541AF0", Offset = "0x25400F0", VA = "0x182541AF0", Slot = "35")]
		public virtual Task WriteValueAsync(DateTimeOffset? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2541BD0", Offset = "0x25401D0", VA = "0x182541BD0", Slot = "36")]
		public virtual Task WriteValueAsync(decimal value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2541CA0", Offset = "0x25402A0", VA = "0x182541CA0", Slot = "37")]
		public virtual Task WriteValueAsync(decimal? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2541D80", Offset = "0x2540380", VA = "0x182541D80", Slot = "38")]
		public virtual Task WriteValueAsync(double value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2541E50", Offset = "0x2540450", VA = "0x182541E50", Slot = "39")]
		public virtual Task WriteValueAsync(double? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2541F20", Offset = "0x2540520", VA = "0x182541F20", Slot = "40")]
		public virtual Task WriteValueAsync(float value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2541FF0", Offset = "0x25405F0", VA = "0x182541FF0", Slot = "41")]
		public virtual Task WriteValueAsync(float? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x25420C0", Offset = "0x25406C0", VA = "0x1825420C0", Slot = "42")]
		public virtual Task WriteValueAsync(Guid value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2542190", Offset = "0x2540790", VA = "0x182542190", Slot = "43")]
		public virtual Task WriteValueAsync(Guid? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2542270", Offset = "0x2540870", VA = "0x182542270", Slot = "44")]
		public virtual Task WriteValueAsync(int value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2542340", Offset = "0x2540940", VA = "0x182542340", Slot = "45")]
		public virtual Task WriteValueAsync(int? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2542410", Offset = "0x2540A10", VA = "0x182542410", Slot = "46")]
		public virtual Task WriteValueAsync(long value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x25424E0", Offset = "0x2540AE0", VA = "0x1825424E0", Slot = "47")]
		public virtual Task WriteValueAsync(long? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x25425B0", Offset = "0x2540BB0", VA = "0x1825425B0", Slot = "48")]
		public virtual Task WriteValueAsync([Nullable(2)] object value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2542680", Offset = "0x2540C80", VA = "0x182542680", Slot = "49")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(sbyte value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2542750", Offset = "0x2540D50", VA = "0x182542750", Slot = "50")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(sbyte? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2542820", Offset = "0x2540E20", VA = "0x182542820", Slot = "51")]
		public virtual Task WriteValueAsync(short value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x25428F0", Offset = "0x2540EF0", VA = "0x1825428F0", Slot = "52")]
		public virtual Task WriteValueAsync(short? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x25429C0", Offset = "0x2540FC0", VA = "0x1825429C0", Slot = "53")]
		public virtual Task WriteValueAsync([Nullable(2)] string value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2542A90", Offset = "0x2541090", VA = "0x182542A90", Slot = "54")]
		public virtual Task WriteValueAsync(TimeSpan value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2542B60", Offset = "0x2541160", VA = "0x182542B60", Slot = "55")]
		public virtual Task WriteValueAsync(TimeSpan? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2542C30", Offset = "0x2541230", VA = "0x182542C30", Slot = "56")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(uint value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2542D00", Offset = "0x2541300", VA = "0x182542D00", Slot = "57")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(uint? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2542DD0", Offset = "0x25413D0", VA = "0x182542DD0", Slot = "58")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(ulong value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2542EA0", Offset = "0x25414A0", VA = "0x182542EA0", Slot = "59")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(ulong? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2542F70", Offset = "0x2541570", VA = "0x182542F70", Slot = "60")]
		public virtual Task WriteValueAsync([Nullable(2)] Uri value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2543040", Offset = "0x2541640", VA = "0x182543040", Slot = "61")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(ushort value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2543110", Offset = "0x2541710", VA = "0x182543110", Slot = "62")]
		[CLSCompliant(false)]
		public virtual Task WriteValueAsync(ushort? value, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x25431E0", Offset = "0x25417E0", VA = "0x1825431E0", Slot = "63")]
		public virtual Task WriteUndefinedAsync([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2543290", Offset = "0x2541890", VA = "0x182543290", Slot = "64")]
		public virtual Task WriteWhitespaceAsync(string ws, [Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2543360", Offset = "0x2541960", VA = "0x182543360")]
		internal Task InternalWriteValueAsync(JsonToken token, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2543400", Offset = "0x2541A00", VA = "0x182543400")]
		protected Task SetWriteStateAsync(JsonToken token, object value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x25436A0", Offset = "0x2541CA0", VA = "0x1825436A0")]
		internal static Task WriteValueAsync(JsonWriter writer, PrimitiveTypeCode typeCode, object value, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x25449D0", Offset = "0x2542FD0", VA = "0x1825449D0")]
		internal static JsonWriter.State[][] BuildStateArray()
		{
			return null;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public bool CloseOutput
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public bool AutoCompleteOnClose
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x170000A0")]
		protected internal int Top
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x2544FB0", Offset = "0x25435B0", VA = "0x182544FB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000A1")]
		public WriteState WriteState
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2545010", Offset = "0x2543610", VA = "0x182545010")]
			get
			{
				return WriteState.Error;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000A2")]
		internal string ContainerPath
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2545150", Offset = "0x2543750", VA = "0x182545150")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000A3")]
		public string Path
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x25451F0", Offset = "0x25437F0", VA = "0x1825451F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003138 File Offset: 0x00001338
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public Formatting Formatting
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return Formatting.None;
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2545330", Offset = "0x2543930", VA = "0x182545330")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return DateFormatHandling.IsoDateFormat;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x25453A0", Offset = "0x25439A0", VA = "0x1825453A0")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return DateTimeZoneHandling.Local;
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2545410", Offset = "0x2543A10", VA = "0x182545410")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x76BE00", Offset = "0x76A400", VA = "0x18076BE00")]
			get
			{
				return StringEscapeHandling.Default;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x2545480", Offset = "0x2543A80", VA = "0x182545480")]
			set
			{
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "65")]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
			get
			{
				return FloatFormatHandling.String;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x2545500", Offset = "0x2543B00", VA = "0x182545500")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		[Nullable(2)]
		public string DateFormatString
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x2545570", Offset = "0x2543B70", VA = "0x182545570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			set
			{
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2545600", Offset = "0x2543C00", VA = "0x182545600")]
		protected JsonWriter()
		{
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x2545620", Offset = "0x2543C20", VA = "0x182545620")]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x2545630", Offset = "0x2543C30", VA = "0x182545630")]
		private void Push(JsonContainerType value)
		{
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x25457E0", Offset = "0x2543DE0", VA = "0x1825457E0")]
		private JsonContainerType Pop()
		{
			return JsonContainerType.None;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		private JsonContainerType Peek()
		{
			return JsonContainerType.None;
		}

		// Token: 0x06000457 RID: 1111
		[Token(Token = "0x6000457")]
		public abstract void Flush();

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2545940", Offset = "0x2543F40", VA = "0x182545940", Slot = "67")]
		public virtual void Close()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x25459B0", Offset = "0x2543FB0", VA = "0x1825459B0", Slot = "68")]
		public virtual void WriteStartObject()
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x25459F0", Offset = "0x2543FF0", VA = "0x1825459F0", Slot = "69")]
		public virtual void WriteEndObject()
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2545A00", Offset = "0x2544000", VA = "0x182545A00", Slot = "70")]
		public virtual void WriteStartArray()
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2545A40", Offset = "0x2544040", VA = "0x182545A40", Slot = "71")]
		public virtual void WriteEndArray()
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2545A50", Offset = "0x2544050", VA = "0x182545A50", Slot = "72")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2545A90", Offset = "0x2544090", VA = "0x182545A90", Slot = "73")]
		public virtual void WriteEndConstructor()
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2545AA0", Offset = "0x25440A0", VA = "0x182545AA0", Slot = "74")]
		public virtual void WritePropertyName(string name)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2545B00", Offset = "0x2544100", VA = "0x182545B00", Slot = "75")]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2545B20", Offset = "0x2544120", VA = "0x182545B20", Slot = "76")]
		public virtual void WriteEnd()
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2545C10", Offset = "0x2544210", VA = "0x182545C10")]
		public void WriteToken(JsonReader reader)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x2545CD0", Offset = "0x25442D0", VA = "0x182545CD0")]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2545D90", Offset = "0x2544390", VA = "0x182545D90")]
		[NullableContext(2)]
		public void WriteToken(JsonToken token, object value)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x25467A0", Offset = "0x2544DA0", VA = "0x1825467A0")]
		public void WriteToken(JsonToken token)
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x25467B0", Offset = "0x2544DB0", VA = "0x1825467B0", Slot = "77")]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x2546A80", Offset = "0x2545080", VA = "0x182546A80")]
		private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth)
		{
			return default(bool);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x2546B50", Offset = "0x2545150", VA = "0x182546B50")]
		private int CalculateWriteTokenInitialDepth(JsonReader reader)
		{
			return 0;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x2546BC0", Offset = "0x25451C0", VA = "0x182546BC0")]
		private int CalculateWriteTokenFinalDepth(JsonReader reader)
		{
			return 0;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x2546C30", Offset = "0x2545230", VA = "0x182546C30")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x2546CF0", Offset = "0x25452F0", VA = "0x182546CF0")]
		private void WriteEnd(JsonContainerType type)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x2546DD0", Offset = "0x25453D0", VA = "0x182546DD0")]
		private void AutoCompleteAll()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x2546E40", Offset = "0x2545440", VA = "0x182546E40")]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return JsonToken.None;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x2546F00", Offset = "0x2545500", VA = "0x182546F00")]
		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x2546FC0", Offset = "0x25455C0", VA = "0x182546FC0")]
		private int CalculateLevelsToComplete(JsonContainerType type)
		{
			return 0;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x25470E0", Offset = "0x25456E0", VA = "0x1825470E0")]
		private void UpdateCurrentState()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "78")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "79")]
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "80")]
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "81")]
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x25471B0", Offset = "0x25457B0", VA = "0x1825471B0")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x25473B0", Offset = "0x25459B0", VA = "0x1825473B0", Slot = "82")]
		public virtual void WriteNull()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x25473D0", Offset = "0x25459D0", VA = "0x1825473D0", Slot = "83")]
		public virtual void WriteUndefined()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "84")]
		[NullableContext(2)]
		public virtual void WriteRaw(string json)
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x25473F0", Offset = "0x25459F0", VA = "0x1825473F0", Slot = "85")]
		[NullableContext(2)]
		public virtual void WriteRawValue(string json)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2547440", Offset = "0x2545A40", VA = "0x182547440", Slot = "86")]
		[NullableContext(2)]
		public virtual void WriteValue(string value)
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "87")]
		public virtual void WriteValue(int value)
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "88")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "89")]
		public virtual void WriteValue(long value)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "90")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2547480", Offset = "0x2545A80", VA = "0x182547480", Slot = "91")]
		public virtual void WriteValue(float value)
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2547480", Offset = "0x2545A80", VA = "0x182547480", Slot = "92")]
		public virtual void WriteValue(double value)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x25474A0", Offset = "0x2545AA0", VA = "0x1825474A0", Slot = "93")]
		public virtual void WriteValue(bool value)
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "94")]
		public virtual void WriteValue(short value)
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "95")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2547440", Offset = "0x2545A40", VA = "0x182547440", Slot = "96")]
		public virtual void WriteValue(char value)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "97")]
		public virtual void WriteValue(byte value)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2547460", Offset = "0x2545A60", VA = "0x182547460", Slot = "98")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2547480", Offset = "0x2545A80", VA = "0x182547480", Slot = "99")]
		public virtual void WriteValue(decimal value)
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x25474C0", Offset = "0x2545AC0", VA = "0x1825474C0", Slot = "100")]
		public virtual void WriteValue(DateTime value)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x25474C0", Offset = "0x2545AC0", VA = "0x1825474C0", Slot = "101")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x2547440", Offset = "0x2545A40", VA = "0x182547440", Slot = "102")]
		public virtual void WriteValue(Guid value)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x2547440", Offset = "0x2545A40", VA = "0x182547440", Slot = "103")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x25474E0", Offset = "0x2545AE0", VA = "0x1825474E0", Slot = "104")]
		public virtual void WriteValue(int? value)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x2547560", Offset = "0x2545B60", VA = "0x182547560", Slot = "105")]
		[CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x25475E0", Offset = "0x2545BE0", VA = "0x1825475E0", Slot = "106")]
		public virtual void WriteValue(long? value)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2547660", Offset = "0x2545C60", VA = "0x182547660", Slot = "107")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x25476E0", Offset = "0x2545CE0", VA = "0x1825476E0", Slot = "108")]
		public virtual void WriteValue(float? value)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x2547760", Offset = "0x2545D60", VA = "0x182547760", Slot = "109")]
		public virtual void WriteValue(double? value)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x25477E0", Offset = "0x2545DE0", VA = "0x1825477E0", Slot = "110")]
		public virtual void WriteValue(bool? value)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2547860", Offset = "0x2545E60", VA = "0x182547860", Slot = "111")]
		public virtual void WriteValue(short? value)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x25478E0", Offset = "0x2545EE0", VA = "0x1825478E0", Slot = "112")]
		[CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2547960", Offset = "0x2545F60", VA = "0x182547960", Slot = "113")]
		public virtual void WriteValue(char? value)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x25479E0", Offset = "0x2545FE0", VA = "0x1825479E0", Slot = "114")]
		public virtual void WriteValue(byte? value)
		{
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2547A60", Offset = "0x2546060", VA = "0x182547A60", Slot = "115")]
		[CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2547AE0", Offset = "0x25460E0", VA = "0x182547AE0", Slot = "116")]
		public virtual void WriteValue(decimal? value)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2547B70", Offset = "0x2546170", VA = "0x182547B70", Slot = "117")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2547BF0", Offset = "0x25461F0", VA = "0x182547BF0", Slot = "118")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2547C80", Offset = "0x2546280", VA = "0x182547C80", Slot = "119")]
		public virtual void WriteValue(Guid? value)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2547D10", Offset = "0x2546310", VA = "0x182547D10", Slot = "120")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2547D90", Offset = "0x2546390", VA = "0x182547D90", Slot = "121")]
		[NullableContext(2)]
		public virtual void WriteValue(byte[] value)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2547DC0", Offset = "0x25463C0", VA = "0x182547DC0", Slot = "122")]
		[NullableContext(2)]
		public virtual void WriteValue(Uri value)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2547E50", Offset = "0x2546450", VA = "0x182547E50", Slot = "123")]
		[NullableContext(2)]
		public virtual void WriteValue(object value)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2547F80", Offset = "0x2546580", VA = "0x182547F80", Slot = "124")]
		[NullableContext(2)]
		public virtual void WriteComment(string text)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2547F90", Offset = "0x2546590", VA = "0x182547F90", Slot = "125")]
		public virtual void WriteWhitespace(string ws)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2547FA0", Offset = "0x25465A0", VA = "0x182547FA0", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2548030", Offset = "0x2546630", VA = "0x182548030", Slot = "126")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2548060", Offset = "0x2546660", VA = "0x182548060")]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x25492C0", Offset = "0x25478C0", VA = "0x1825492C0")]
		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x25494F0", Offset = "0x2547AF0", VA = "0x1825494F0")]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x25495E0", Offset = "0x2547BE0", VA = "0x1825495E0")]
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2546F00", Offset = "0x2545500", VA = "0x182546F00")]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2545AA0", Offset = "0x25440A0", VA = "0x182545AA0")]
		internal void InternalWritePropertyName(string name)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2549870", Offset = "0x2547E70", VA = "0x182549870")]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x25498B0", Offset = "0x2547EB0", VA = "0x1825498B0")]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x25498D0", Offset = "0x2547ED0", VA = "0x1825498D0")]
		internal void InternalWriteWhitespace(string ws)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2547F80", Offset = "0x2546580", VA = "0x182547F80")]
		internal void InternalWriteComment()
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x25499C0", Offset = "0x2547FC0", VA = "0x1825499C0")]
		[CompilerGenerated]
		private Task <InternalWriteEndAsync>g__AwaitProperty|11_0(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken)
		{
			return null;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2549C20", Offset = "0x2548220", VA = "0x182549C20")]
		[CompilerGenerated]
		private Task <InternalWriteEndAsync>g__AwaitIndent|11_1(Task task, int LevelsToComplete, JsonToken token, CancellationToken CancellationToken)
		{
			return null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2549E80", Offset = "0x2548480", VA = "0x182549E80")]
		[CompilerGenerated]
		private Task <InternalWriteEndAsync>g__AwaitEnd|11_2(Task task, int LevelsToComplete, CancellationToken CancellationToken)
		{
			return null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x254A0D0", Offset = "0x25486D0", VA = "0x18254A0D0")]
		[CompilerGenerated]
		private Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, CancellationToken CancellationToken)
		{
			return null;
		}

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly JsonWriter.State[][] StateArray;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly JsonWriter.State[][] StateArrayTemplate;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Nullable(2)]
		private List<JsonPosition> _stack;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private JsonWriter.State _currentState;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Nullable(2)]
		private string _dateFormatString;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Nullable(2)]
		private CultureInfo _culture;

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		[NullableContext(0)]
		internal enum State
		{
			// Token: 0x040002DC RID: 732
			[Token(Token = "0x40002DC")]
			Start,
			// Token: 0x040002DD RID: 733
			[Token(Token = "0x40002DD")]
			Property,
			// Token: 0x040002DE RID: 734
			[Token(Token = "0x40002DE")]
			ObjectStart,
			// Token: 0x040002DF RID: 735
			[Token(Token = "0x40002DF")]
			Object,
			// Token: 0x040002E0 RID: 736
			[Token(Token = "0x40002E0")]
			ArrayStart,
			// Token: 0x040002E1 RID: 737
			[Token(Token = "0x40002E1")]
			Array,
			// Token: 0x040002E2 RID: 738
			[Token(Token = "0x40002E2")]
			ConstructorStart,
			// Token: 0x040002E3 RID: 739
			[Token(Token = "0x40002E3")]
			Constructor,
			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			Closed,
			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			Error
		}
	}
}
