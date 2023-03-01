using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Inventory
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	public class LayoutItem : MonoBehaviour
	{
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053A")]
		public ItemInstance ItemInstance
		{
			[Token(Token = "0x60027AD")]
			[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027AE")]
			[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x060027B0 RID: 10160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053B")]
		public bool IsHighlighted
		{
			[Token(Token = "0x60027AF")]
			[Address(RVA = "0x86F2E0", Offset = "0x86E2E0", VA = "0x18086F2E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027B0")]
			[Address(RVA = "0x86F330", Offset = "0x86E330", VA = "0x18086F330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x1700053C")]
		public bool DoNotSnap
		{
			[Token(Token = "0x60027B1")]
			[Address(RVA = "0x1EA0400", Offset = "0x1E9F400", VA = "0x181EA0400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053D")]
		public UnityEvent<LayoutItem> OnMouseEnterEvent
		{
			[Token(Token = "0x60027B2")]
			[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053E")]
		public UnityEvent<LayoutItem> OnMouseExitEvent
		{
			[Token(Token = "0x60027B3")]
			[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		public UnityEvent<LayoutItem> OnMouseOverEvent
		{
			[Token(Token = "0x60027B4")]
			[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x2DC1280", Offset = "0x2DC0280", VA = "0x182DC1280", Slot = "4")]
		protected virtual void Update()
		{
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x2DC1090", Offset = "0x2DC0090", VA = "0x182DC1090", Slot = "5")]
		public virtual void Reset()
		{
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x2DC11C0", Offset = "0x2DC01C0", VA = "0x182DC11C0")]
		private void Start()
		{
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x2DC08D0", Offset = "0x2DBF8D0", VA = "0x182DC08D0", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x23B3DD0", Offset = "0x23B2DD0", VA = "0x1823B3DD0", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x2DC08F0", Offset = "0x2DBF8F0", VA = "0x182DC08F0", Slot = "8")]
		protected virtual void OnMouseEnter()
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x2DC0950", Offset = "0x2DBF950", VA = "0x182DC0950", Slot = "9")]
		protected virtual void OnMouseExit()
		{
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x2DC09B0", Offset = "0x2DBF9B0", VA = "0x182DC09B0", Slot = "10")]
		protected virtual void OnMouseOver()
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x2DC10A0", Offset = "0x2DC00A0", VA = "0x182DC10A0")]
		public void SetItemInstance(ItemInstance itemInstance)
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x2DC0850", Offset = "0x2DBF850", VA = "0x182DC0850", Slot = "11")]
		public virtual void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x2DC0D40", Offset = "0x2DBFD40", VA = "0x182DC0D40")]
		protected void RefreshInteractionComponents()
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "12")]
		public virtual void OnAddedToLayoutGroup()
		{
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x2DC0500", Offset = "0x2DBF500", VA = "0x182DC0500")]
		private void InitMeshOutliner()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x2DC0A10", Offset = "0x2DBFA10", VA = "0x182DC0A10")]
		public void OutlineMesh(bool enable)
		{
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x2DC1360", Offset = "0x2DC0360", VA = "0x182DC1360")]
		public LayoutItem()
		{
		}

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x0")]
		[ColorUsage(true, true)]
		private static readonly Color DefaultMeshOutlineColor;

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float _uiTriggerDelay;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _doNotSnap;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0x28")]
		protected float _uiTriggerTime;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[FieldOffset(Offset = "0x30")]
		private List<MeshOutliner> _meshOutliners;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[FieldOffset(Offset = "0x38")]
		protected List<Renderer> _renderers;
	}
}
