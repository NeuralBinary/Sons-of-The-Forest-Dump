using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[Serializable]
	public struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		// Token: 0x06000A5C RID: 2652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x902DF0", Offset = "0x9013F0", VA = "0x180902DF0")]
		public SteamInventoryUpdateHandle_t(ulong value)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x98A040", Offset = "0x988640", VA = "0x18098A040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x98B100", Offset = "0x989700", VA = "0x18098B100", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00008E7C File Offset: 0x0000707C
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x903190", Offset = "0x901790", VA = "0x180903190", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x785B20", Offset = "0x784120", VA = "0x180785B20")]
		public static bool operator ==(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00008EAC File Offset: 0x000070AC
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x98B1A0", Offset = "0x9897A0", VA = "0x18098B1A0")]
		public static bool operator !=(SteamInventoryUpdateHandle_t x, SteamInventoryUpdateHandle_t y)
		{
			return default(bool);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00008EC4 File Offset: 0x000070C4
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator SteamInventoryUpdateHandle_t(ulong value)
		{
			return default(SteamInventoryUpdateHandle_t);
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00008EDC File Offset: 0x000070DC
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x709210", Offset = "0x707810", VA = "0x180709210")]
		public static explicit operator ulong(SteamInventoryUpdateHandle_t that)
		{
			return 0UL;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00008EF4 File Offset: 0x000070F4
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x98A0D0", Offset = "0x9886D0", VA = "0x18098A0D0", Slot = "4")]
		public bool Equals(SteamInventoryUpdateHandle_t other)
		{
			return default(bool);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00008F0C File Offset: 0x0000710C
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x98A0E0", Offset = "0x9886E0", VA = "0x18098A0E0", Slot = "5")]
		public int CompareTo(SteamInventoryUpdateHandle_t other)
		{
			return 0;
		}

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SteamInventoryUpdateHandle_t Invalid;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamInventoryUpdateHandle;
	}
}
