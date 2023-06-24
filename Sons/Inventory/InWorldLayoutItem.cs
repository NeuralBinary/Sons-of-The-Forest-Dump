using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	[AddComponentMenu("Sons/Inventory/InWorldLayoutItem")]
	public class InWorldLayoutItem : LayoutItem
	{
		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		public override void Reset()
		{
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		protected override void Update()
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		protected override void OnMouseEnter()
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		protected override void OnMouseExit()
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		protected override void OnMouseOver()
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public override void OnAddedToLayoutGroup()
		{
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x33D9D40", Offset = "0x33D8340", VA = "0x1833D9D40", Slot = "11")]
		public override void Initialize(Transform rootTransform)
		{
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x33D9E70", Offset = "0x33D8470", VA = "0x1833D9E70")]
		public void SetActiveColliders(bool value)
		{
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x33DA050", Offset = "0x33D8650", VA = "0x1833DA050")]
		public InWorldLayoutItem()
		{
		}

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_activeColliders")]
		[SerializeField]
		private List<Collider> _activeWorldColliders;
	}
}
