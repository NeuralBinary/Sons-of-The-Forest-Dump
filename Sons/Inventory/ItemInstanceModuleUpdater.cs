using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x02000623 RID: 1571
	[Token(Token = "0x2000623")]
	public class ItemInstanceModuleUpdater : MonoBehaviour
	{
		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054D")]
		public static ItemInstanceModuleUpdater Instance
		{
			[Token(Token = "0x60028C0")]
			[Address(RVA = "0x33E3D70", Offset = "0x33E2370", VA = "0x1833E3D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x1700054E")]
		public static bool HasInstance
		{
			[Token(Token = "0x60028C1")]
			[Address(RVA = "0x33E3DB0", Offset = "0x33E23B0", VA = "0x1833E3DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0xA875A0", Offset = "0xA85BA0", VA = "0x180A875A0")]
		private void Update()
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x33E3EA0", Offset = "0x33E24A0", VA = "0x1833E3EA0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x33E3EE0", Offset = "0x33E24E0", VA = "0x1833E3EE0")]
		public static void Initialize()
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x33E40C0", Offset = "0x33E26C0", VA = "0x1833E40C0")]
		public ItemInstanceModuleUpdater()
		{
		}

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnUpdate;

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x0")]
		private static ItemInstanceModuleUpdater _instance;

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInitialized;
	}
}
