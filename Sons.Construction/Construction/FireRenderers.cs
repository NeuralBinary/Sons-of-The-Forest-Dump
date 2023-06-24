using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	[Serializable]
	public class FireRenderers
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x2EF4B40", Offset = "0x2EF3140", VA = "0x182EF4B40")]
		public void SetFresh()
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x2EF4E50", Offset = "0x2EF3450", VA = "0x182EF4E50")]
		public void SetLit()
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x2EF5160", Offset = "0x2EF3760", VA = "0x182EF5160")]
		internal void SetBurnt()
		{
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FireRenderers()
		{
		}

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<FireRenderers.RenderersGroup> _rendererGroups;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _litRoot;

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unlitRoot;

		// Token: 0x020001EF RID: 495
		[Token(Token = "0x20001EF")]
		[Serializable]
		public class RenderersGroup
		{
			// Token: 0x06000EE3 RID: 3811 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x2EF5470", Offset = "0x2EF3A70", VA = "0x182EF5470")]
			private void SetAll(Material mat)
			{
			}

			// Token: 0x06000EE4 RID: 3812 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EE4")]
			[Address(RVA = "0x2EF55F0", Offset = "0x2EF3BF0", VA = "0x182EF55F0")]
			public void SetFresh()
			{
			}

			// Token: 0x06000EE5 RID: 3813 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EE5")]
			[Address(RVA = "0x2EF5600", Offset = "0x2EF3C00", VA = "0x182EF5600")]
			public void SetAlight()
			{
			}

			// Token: 0x06000EE6 RID: 3814 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x2EF5610", Offset = "0x2EF3C10", VA = "0x182EF5610")]
			public void SetBurnt()
			{
			}

			// Token: 0x06000EE7 RID: 3815 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RenderersGroup()
			{
			}

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Material Fresh;

			// Token: 0x04000816 RID: 2070
			[Token(Token = "0x4000816")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Material Alight;

			// Token: 0x04000817 RID: 2071
			[Token(Token = "0x4000817")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Material Burnt;

			// Token: 0x04000818 RID: 2072
			[Token(Token = "0x4000818")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private List<Renderer> _renderers;
		}
	}
}
