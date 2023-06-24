using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Serializable]
	public struct servernetadr_t
	{
		// Token: 0x06000992 RID: 2450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000992")]
		[Address(RVA = "0x9895A0", Offset = "0x987BA0", VA = "0x1809895A0")]
		public void Init(uint ip, ushort usQueryPort, ushort usConnectionPort)
		{
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00008204 File Offset: 0x00006404
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x9895B0", Offset = "0x987BB0", VA = "0x1809895B0")]
		public ushort GetQueryPort()
		{
			return 0;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x9895C0", Offset = "0x987BC0", VA = "0x1809895C0")]
		public void SetQueryPort(ushort usPort)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0000821C File Offset: 0x0000641C
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x9895D0", Offset = "0x987BD0", VA = "0x1809895D0")]
		public ushort GetConnectionPort()
		{
			return 0;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x9895E0", Offset = "0x987BE0", VA = "0x1809895E0")]
		public void SetConnectionPort(ushort usPort)
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00008234 File Offset: 0x00006434
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x9895F0", Offset = "0x987BF0", VA = "0x1809895F0")]
		public uint GetIP()
		{
			return 0U;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x989600", Offset = "0x987C00", VA = "0x180989600")]
		public void SetIP(uint unIP)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x989610", Offset = "0x987C10", VA = "0x180989610")]
		public string GetConnectionAddressString()
		{
			return null;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x989620", Offset = "0x987C20", VA = "0x180989620")]
		public string GetQueryAddressString()
		{
			return null;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x989630", Offset = "0x987C30", VA = "0x180989630")]
		public static string ToString(uint unIP, ushort usPort)
		{
			return null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0000824C File Offset: 0x0000644C
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x989890", Offset = "0x987E90", VA = "0x180989890")]
		public static bool operator <(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00008264 File Offset: 0x00006464
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x9898C0", Offset = "0x987EC0", VA = "0x1809898C0")]
		public static bool operator >(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0000827C File Offset: 0x0000647C
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x9898F0", Offset = "0x987EF0", VA = "0x1809898F0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00008294 File Offset: 0x00006494
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x9899A0", Offset = "0x987FA0", VA = "0x1809899A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000082AC File Offset: 0x000064AC
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x9899B0", Offset = "0x987FB0", VA = "0x1809899B0")]
		public static bool operator ==(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000082C4 File Offset: 0x000064C4
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x9899F0", Offset = "0x987FF0", VA = "0x1809899F0")]
		public static bool operator !=(servernetadr_t x, servernetadr_t y)
		{
			return default(bool);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000082DC File Offset: 0x000064DC
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x989A30", Offset = "0x988030", VA = "0x180989A30")]
		public bool Equals(servernetadr_t other)
		{
			return default(bool);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x000082F4 File Offset: 0x000064F4
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x989A60", Offset = "0x988060", VA = "0x180989A60")]
		public int CompareTo(servernetadr_t other)
		{
			return 0;
		}

		// Token: 0x04000A5E RID: 2654
		[Token(Token = "0x4000A5E")]
		[FieldOffset(Offset = "0x0")]
		private ushort m_usConnectionPort;

		// Token: 0x04000A5F RID: 2655
		[Token(Token = "0x4000A5F")]
		[FieldOffset(Offset = "0x2")]
		private ushort m_usQueryPort;

		// Token: 0x04000A60 RID: 2656
		[Token(Token = "0x4000A60")]
		[FieldOffset(Offset = "0x4")]
		private uint m_unIP;
	}
}
