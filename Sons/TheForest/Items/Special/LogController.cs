using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bolt;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using TheForest.Items.Inventory;
using UnityEngine;

namespace TheForest.Items.Special
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	public class LogController : EntityBehaviour<IPlayerState>
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EAC RID: 7852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public ItemInstance HeldItem
		{
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x1700043F")]
		public int Amount
		{
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x32F4180", Offset = "0x32F2780", VA = "0x1832F4180")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x17000440")]
		public bool HasLogs
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x32F41B0", Offset = "0x32F27B0", VA = "0x1832F41B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EB0 RID: 7856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000441")]
		public Transform HeldLogOverrideForDrops
		{
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x32F41E0", Offset = "0x32F27E0", VA = "0x1832F41E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x32F43F0", Offset = "0x32F29F0", VA = "0x1832F43F0")]
		public bool Lift(int itemId, [Optional] ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x32F4420", Offset = "0x32F2A20", VA = "0x1832F4420")]
		public bool Lift()
		{
			return default(bool);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x32F4450", Offset = "0x32F2A50", VA = "0x1832F4450")]
		public void RemoveLog(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x32F4470", Offset = "0x32F2A70", VA = "0x1832F4470")]
		public bool DropAll(bool fake = false, bool drop = false, bool equipPrevious = true)
		{
			return default(bool);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x32F44B0", Offset = "0x32F2AB0", VA = "0x1832F44B0")]
		public bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1)
		{
			return default(bool);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x32F4500", Offset = "0x32F2B00", VA = "0x1832F4500")]
		public bool Controlling(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x32F41B0", Offset = "0x32F27B0", VA = "0x1832F41B0")]
		public bool Has(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x32F4450", Offset = "0x32F2A50", VA = "0x1832F4450")]
		public void RemoveHeldItem(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x32F4590", Offset = "0x32F2B90", VA = "0x1832F4590")]
		private void DrawLogGizmo(GameObject target, Vector3 offset)
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x32F4B20", Offset = "0x32F3120", VA = "0x1832F4B20")]
		private void DebugAwake()
		{
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		private void SetVirtualLog(bool virtualLogValue)
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x32F4BD0", Offset = "0x32F31D0", VA = "0x1832F4BD0")]
		public LogController()
		{
		}

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[ItemIdPicker]
		public int _logItemId;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PlayerInventory _player;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public HeldOnlyItemController _heldItemController;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _debugVirtualLog;

		// Token: 0x04001CAB RID: 7339
		[Token(Token = "0x4001CAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _gizmoLogSize;

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 _gizmoSecondLogOffset;
	}
}
