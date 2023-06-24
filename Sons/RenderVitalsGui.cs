using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Sons
{
	// Token: 0x020004D6 RID: 1238
	[Token(Token = "0x20004D6")]
	[Serializable]
	public class RenderVitalsGui : CustomPass
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002065")]
		[Address(RVA = "0x3314510", Offset = "0x3312B10", VA = "0x183314510")]
		public static void SetSourceCamera(Camera value)
		{
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002066")]
		[Address(RVA = "0x33145C0", Offset = "0x3312BC0", VA = "0x1833145C0")]
		public static void SetSourceRenderers(List<Renderer> source, bool reorder = true)
		{
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002067")]
		[Address(RVA = "0x3314780", Offset = "0x3312D80", VA = "0x183314780", Slot = "10")]
		protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
		{
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x3314B60", Offset = "0x3313160", VA = "0x183314B60", Slot = "9")]
		protected override void Execute(CustomPassContext ctx)
		{
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002069")]
		[Address(RVA = "0x3315690", Offset = "0x3313C90", VA = "0x183315690")]
		private static List<Renderer> OrderRenderers(List<Renderer> renderers, Camera sourceCamera)
		{
			return null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		protected override void Cleanup()
		{
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206B")]
		[Address(RVA = "0x5D6C10", Offset = "0x5D5210", VA = "0x1805D6C10")]
		public RenderVitalsGui()
		{
		}

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _validCameraTag;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RenderTexture _renderTexture;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _shaderPass;

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int _submeshIndex;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x0")]
		private static List<Renderer> _sourceRenderers;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x8")]
		private static Camera _sourceCamera;
	}
}
