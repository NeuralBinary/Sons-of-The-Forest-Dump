using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	public class LayoutItem : MonoBehaviour
	{
		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028C7 RID: 10439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60028C6")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		// (set) Token: 0x060028C9 RID: 10441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000550")]
		public bool IsHighlighted
		{
			[Token(Token = "0x60028C8")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028C9")]
			[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x17000551")]
		public bool DoNotSnap
		{
			[Token(Token = "0x60028CA")]
			[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public UnityEvent<LayoutItem> OnMouseEnterEvent
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000553")]
		public UnityEvent<LayoutItem> OnMouseExitEvent
		{
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000554")]
		public UnityEvent<LayoutItem> OnMouseOverEvent
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x33E4200", Offset = "0x33E2800", VA = "0x1833E4200", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x33E42E0", Offset = "0x33E28E0", VA = "0x1833E42E0", Slot = "5")]
		public virtual void Reset()
		{
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x33E42F0", Offset = "0x33E28F0", VA = "0x1833E42F0")]
		private void Start()
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x33E4410", Offset = "0x33E2A10", VA = "0x1833E4410", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x2830D10", Offset = "0x282F310", VA = "0x182830D10", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x33E4430", Offset = "0x33E2A30", VA = "0x1833E4430", Slot = "8")]
		protected virtual void OnMouseEnter()
		{
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x33E4490", Offset = "0x33E2A90", VA = "0x1833E4490", Slot = "9")]
		protected virtual void OnMouseExit()
		{
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x33E44F0", Offset = "0x33E2AF0", VA = "0x1833E44F0", Slot = "10")]
		protected virtual void OnMouseOver()
		{
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x33E4550", Offset = "0x33E2B50", VA = "0x1833E4550")]
		public void SetItemInstance(ItemInstance itemInstance)
		{
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x33E4740", Offset = "0x33E2D40", VA = "0x1833E4740", Slot = "11")]
		public virtual void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x33E4880", Offset = "0x33E2E80", VA = "0x1833E4880")]
		protected void RefreshInteractionComponents()
		{
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public virtual void OnAddedToLayoutGroup()
		{
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x33E4CE0", Offset = "0x33E32E0", VA = "0x1833E4CE0")]
		private void InitMeshOutliner()
		{
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DB")]
		[Address(RVA = "0x33E51B0", Offset = "0x33E37B0", VA = "0x1833E51B0")]
		public void OutlineMesh(bool enable)
		{
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028DC")]
		[Address(RVA = "0x33E5680", Offset = "0x33E3C80", VA = "0x1833E5680")]
		public LayoutItem()
		{
		}

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x0")]
		[ColorUsage(true, true)]
		private static readonly Color DefaultMeshOutlineColor;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _uiTriggerDelay;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _doNotSnap;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _setToInventoryLayer;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x28")]
		protected float _uiTriggerTime;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x30")]
		private List<MeshOutliner> _meshOutliners;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x38")]
		protected List<Renderer> _renderers;
	}
}
