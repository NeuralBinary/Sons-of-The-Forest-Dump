using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

namespace Sons
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[Serializable]
	public class RenderVitalsGui : CustomPass
	{
		// Token: 0x06002000 RID: 8192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x2D31270", Offset = "0x2D30270", VA = "0x182D31270")]
		public static void SetSourceCamera(Camera value)
		{
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x2D312E0", Offset = "0x2D302E0", VA = "0x182D312E0")]
		public static void SetSourceRenderers(List<Renderer> source, bool reorder = true)
		{
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x2D31590", Offset = "0x2D30590", VA = "0x182D31590", Slot = "10")]
		protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
		{
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x2D30A20", Offset = "0x2D2FA20", VA = "0x182D30A20", Slot = "9")]
		protected override void Execute(CustomPassContext ctx)
		{
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x2D310C0", Offset = "0x2D300C0", VA = "0x182D310C0")]
		private static List<Renderer> OrderRenderers(List<Renderer> renderers, Camera sourceCamera)
		{
			return null;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "11")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x559CF0", Offset = "0x558CF0", VA = "0x180559CF0")]
		public RenderVitalsGui()
		{
		}

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _validCameraTag;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RenderTexture _renderTexture;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _shaderPass;

		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4001D96")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int _submeshIndex;

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x0")]
		private static List<Renderer> _sourceRenderers;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x8")]
		private static Camera _sourceCamera;
	}
}
