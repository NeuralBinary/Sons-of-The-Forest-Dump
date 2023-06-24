using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	internal static class Factory
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x170000F3")]
		internal static bool IsEmpty
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x8E88D0", Offset = "0x8E6ED0", VA = "0x1808E88D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x8E8940", Offset = "0x8E6F40", VA = "0x1808E8940")]
		internal static void Register(IFactory factory)
		{
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x8E8B60", Offset = "0x8E7160", VA = "0x1808E8B60")]
		internal static IFactory GetFactory(TypeId id)
		{
			return null;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x8E8BE0", Offset = "0x8E71E0", VA = "0x1808E8BE0")]
		internal static IFactory GetFactory(UniqueId id)
		{
			return null;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x8E8C60", Offset = "0x8E7260", VA = "0x1808E8C60")]
		internal static IEventFactory GetEventFactory(TypeId id)
		{
			return null;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x8E8D20", Offset = "0x8E7320", VA = "0x1808E8D20")]
		internal static IEventFactory GetEventFactory(UniqueId id)
		{
			return null;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x8E8DF0", Offset = "0x8E73F0", VA = "0x1808E8DF0")]
		internal static Event NewEvent(TypeId id)
		{
			return null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x8E8E90", Offset = "0x8E7490", VA = "0x1808E8E90")]
		internal static Event NewEvent(UniqueId id)
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x8E8FB0", Offset = "0x8E75B0", VA = "0x1808E8FB0")]
		internal static byte GetTokenId(IProtocolToken obj)
		{
			return 0;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x8E9090", Offset = "0x8E7690", VA = "0x1808E9090")]
		internal static IProtocolToken NewToken(byte id)
		{
			return null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x8E9160", Offset = "0x8E7760", VA = "0x1808E9160")]
		internal static Command NewCommand(TypeId id)
		{
			return null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x8E9200", Offset = "0x8E7800", VA = "0x1808E9200")]
		internal static Command NewCommand(UniqueId id)
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x8E9320", Offset = "0x8E7920", VA = "0x1808E9320")]
		internal static IEntitySerializer NewSerializer(TypeId id)
		{
			return null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x8E93B0", Offset = "0x8E79B0", VA = "0x1808E93B0")]
		internal static IEntitySerializer NewSerializer(UniqueId guid)
		{
			return null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x8E94D0", Offset = "0x8E7AD0", VA = "0x1808E94D0")]
		private static object Create(TypeId id)
		{
			return null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x8E9570", Offset = "0x8E7B70", VA = "0x1808E9570")]
		private static object Create(UniqueId id)
		{
			return null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x8E9620", Offset = "0x8E7C20", VA = "0x1808E9620")]
		internal static void UnregisterAll()
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x8E9D30", Offset = "0x8E8330", VA = "0x1808E9D30")]
		internal static void RegisterTokenClass(Type type)
		{
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<byte, Type> _id2token;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, byte> _token2id;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, IFactory> _factoriesByType;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<TypeId, IFactory> _factoriesById;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<UniqueId, IFactory> _factoriesByKey;
	}
}
