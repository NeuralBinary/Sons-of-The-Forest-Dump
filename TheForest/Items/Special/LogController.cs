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
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class LogController : EntityBehaviour<IPlayerState>
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000434")]
		public ItemInstance HeldItem
		{
			[Token(Token = "0x6001E59")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E5A")]
			[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x17000435")]
		public int Amount
		{
			[Token(Token = "0x6001E5B")]
			[Address(RVA = "0x2D131C0", Offset = "0x2D121C0", VA = "0x182D131C0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x17000436")]
		public bool HasLogs
		{
			[Token(Token = "0x6001E5C")]
			[Address(RVA = "0x2D12F10", Offset = "0x2D11F10", VA = "0x182D12F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E5E RID: 7774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000437")]
		public Transform HeldLogOverrideForDrops
		{
			[Token(Token = "0x6001E5D")]
			[Address(RVA = "0x5E65C0", Offset = "0x5E55C0", VA = "0x1805E65C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E5E")]
			[Address(RVA = "0x5E65D0", Offset = "0x5E55D0", VA = "0x1805E65D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x2D12FA0", Offset = "0x2D11FA0", VA = "0x182D12FA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x2D12F40", Offset = "0x2D11F40", VA = "0x182D12F40")]
		public bool Lift(int itemId, [Optional] ItemInstance itemInstance)
		{
			return default(bool);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x2D12F70", Offset = "0x2D11F70", VA = "0x182D12F70")]
		public bool Lift()
		{
			return default(bool);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x2D13120", Offset = "0x2D12120", VA = "0x182D13120")]
		public void RemoveLog(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x2D12ED0", Offset = "0x2D11ED0", VA = "0x182D12ED0")]
		public bool DropAll(bool fake = false, bool drop = false, bool equipPrevious = true)
		{
			return default(bool);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x2D130D0", Offset = "0x2D120D0", VA = "0x182D130D0")]
		public bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1)
		{
			return default(bool);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x2D12B00", Offset = "0x2D11B00", VA = "0x182D12B00")]
		public bool Controlling(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x2D12F10", Offset = "0x2D11F10", VA = "0x182D12F10")]
		public bool Has(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x2D13120", Offset = "0x2D12120", VA = "0x182D13120")]
		public void RemoveHeldItem(bool equipPrevious, bool drop = true)
		{
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x2D12C20", Offset = "0x2D11C20", VA = "0x182D12C20")]
		private void DrawLogGizmo(GameObject target, Vector3 offset)
		{
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E69")]
		[Address(RVA = "0x2D12B70", Offset = "0x2D11B70", VA = "0x182D12B70")]
		private void DebugAwake()
		{
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x580620", Offset = "0x57F620", VA = "0x180580620")]
		private void SetVirtualLog(bool virtualLogValue)
		{
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x2D13140", Offset = "0x2D12140", VA = "0x182D13140")]
		public LogController()
		{
		}

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x28")]
		[ItemIdPicker]
		public int _logItemId;

		// Token: 0x04001C70 RID: 7280
		[Token(Token = "0x4001C70")]
		[FieldOffset(Offset = "0x2C")]
		[ItemIdPicker]
		public int _lighterItemId;

		// Token: 0x04001C71 RID: 7281
		[Token(Token = "0x4001C71")]
		[FieldOffset(Offset = "0x30")]
		public PlayerInventory _player;

		// Token: 0x04001C72 RID: 7282
		[Token(Token = "0x4001C72")]
		[FieldOffset(Offset = "0x38")]
		public HeldOnlyItemController _heldItemController;

		// Token: 0x04001C75 RID: 7285
		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _debugVirtualLog;

		// Token: 0x04001C76 RID: 7286
		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Vector3 _gizmoLogSize;

		// Token: 0x04001C77 RID: 7287
		[Token(Token = "0x4001C77")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector3 _gizmoSecondLogOffset;
	}
}
