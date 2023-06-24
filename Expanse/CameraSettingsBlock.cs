using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[Serializable]
	public class CameraSettingsBlock : MonoBehaviour
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xAB5A10", Offset = "0xAB4010", VA = "0x180AB5A10")]
		private void Update()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xAB5B60", Offset = "0xAB4160", VA = "0x180AB5B60")]
		public CameraSettingsBlock()
		{
		}

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Camera that Expanse's ambient probe is rendered for. Defaults to the scene's main camera.")]
		public Camera m_ambientProbeCamera;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Prefer to render the ambient probe relative to the editor camera if both the editor and main camera are rendering.")]
		public bool m_preferEditorCamera;
	}
}
