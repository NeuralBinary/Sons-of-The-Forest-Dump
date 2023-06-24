using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Inventory;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	[AddComponentMenu("Sons/Construction/Presets/SawHorse/StructureElementItemVisualController")]
	public class StructureElementItemVisualController : MonoBehaviour, IStructureElementVisualController
	{
		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003A3")]
		public StructureElement Instance
		{
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003A4")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x2F00F40", Offset = "0x2EFF540", VA = "0x182F00F40", Slot = "4")]
		public void SetElementId(uint elementId)
		{
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x2F013F0", Offset = "0x2EFF9F0", VA = "0x182F013F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x2F01550", Offset = "0x2EFFB50", VA = "0x182F01550")]
		public void Clear()
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x2F016E0", Offset = "0x2EFFCE0", VA = "0x182F016E0")]
		public void SetItemInstance(ItemInstance itemInstance, ItemData item, ElementProfile elementProfile)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public StructureElementItemVisualController()
		{
		}

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x20")]
		private StructureElement _instance;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x28")]
		private uint _elementId;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x30")]
		private int[] _instanceAmounts;
	}
}
