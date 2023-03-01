using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x200055F")]
	[AddComponentMenu("Sons/Gui/ScreenSpaceWorldLocators")]
	public class ScreenSpaceWorldLocators : MonoBehaviour
	{
		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x2D8EF40", Offset = "0x2D8DF40", VA = "0x182D8EF40")]
		private void LateUpdate()
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x2D8EEC0", Offset = "0x2D8DEC0", VA = "0x182D8EEC0")]
		private Camera GetCamera()
		{
			return null;
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x2D8F2B0", Offset = "0x2D8E2B0", VA = "0x182D8F2B0")]
		public ScreenSpaceWorldLocators()
		{
		}

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _uiMarker;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _parentTransform;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _alwaysShowOnScreen;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _screenPaddingX;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _screenPaddingY;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		[FieldOffset(Offset = "0x40")]
		private Camera _cachedCamera;
	}
}
