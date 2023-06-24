using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Expanse
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public static class GameplayQueries
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xAF9330", Offset = "0xAF7930", VA = "0x180AF9330")]
		public static void Dispatch(GameplayQueries.QueryInfo query, Action<GameplayQueries.QueryInfo> callback)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xAF94A0", Offset = "0xAF7AA0", VA = "0x180AF94A0")]
		public static void BeginProcessing()
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xAF95F0", Offset = "0xAF7BF0", VA = "0x180AF95F0")]
		public static void EndProcessing()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xAF9740", Offset = "0xAF7D40", VA = "0x180AF9740")]
		public static List<GameplayQueries.QueryInfo> GetInProgressQueries()
		{
			return null;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xAF9790", Offset = "0xAF7D90", VA = "0x180AF9790")]
		public static List<Action<GameplayQueries.QueryInfo>> GetInProgressCallbacks()
		{
			return null;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00004DB2 File Offset: 0x00002FB2
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xAF97E0", Offset = "0xAF7DE0", VA = "0x180AF97E0")]
		public static List<Action<GameplayQueries.QueryInfo>> GetProcessedCallbacks()
		{
			return null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xAF9830", Offset = "0xAF7E30", VA = "0x180AF9830")]
		public static void ClearProcessed(int toClear)
		{
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xAF9970", Offset = "0xAF7F70", VA = "0x180AF9970")]
		public static void ClearProcessed()
		{
		}

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x0")]
		private static List<GameplayQueries.QueryInfo> s_waitingQueries;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x8")]
		private static List<Action<GameplayQueries.QueryInfo>> s_waitingCallbacks;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x10")]
		private static List<GameplayQueries.QueryInfo> s_inProgressQueries;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x18")]
		private static List<Action<GameplayQueries.QueryInfo>> s_inProgressCallbacks;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x20")]
		private static List<GameplayQueries.QueryInfo> s_processedQueries;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x28")]
		private static List<Action<GameplayQueries.QueryInfo>> s_processedCallbacks;

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "P:\\Jenkins\\workspace\\Build Sons Of The Forest PC\\Assets\\Assemblies\\External\\Expanse\\code\\source\\main\\GameplayQueries.cs", needAccessors = false)]
		public struct QueryInfo
		{
			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 startWS;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 endWS;

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			[FieldOffset(Offset = "0x18")]
			public float density;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			[FieldOffset(Offset = "0x1C")]
			public float visibility;
		}
	}
}
