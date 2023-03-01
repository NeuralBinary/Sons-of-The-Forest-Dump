using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	public class ItemInstanceModuleUpdater : MonoBehaviour
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000538")]
		public static ItemInstanceModuleUpdater Instance
		{
			[Token(Token = "0x60027A7")]
			[Address(RVA = "0x2DBE7C0", Offset = "0x2DBD7C0", VA = "0x182DBE7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x17000539")]
		public static bool HasInstance
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x2DBE740", Offset = "0x2DBD740", VA = "0x182DBE740")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x92EFB0", Offset = "0x92DFB0", VA = "0x18092EFB0")]
		private void Update()
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x2DBE690", Offset = "0x2DBD690", VA = "0x182DBE690")]
		private void OnDestroy()
		{
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x2DBE4E0", Offset = "0x2DBD4E0", VA = "0x182DBE4E0")]
		public static void Initialize()
		{
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x2DBE6D0", Offset = "0x2DBD6D0", VA = "0x182DBE6D0")]
		public ItemInstanceModuleUpdater()
		{
		}

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnUpdate;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x0")]
		private static ItemInstanceModuleUpdater _instance;

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInitialized;
	}
}
