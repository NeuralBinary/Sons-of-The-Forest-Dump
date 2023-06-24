using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	[AddComponentMenu("Sons/Gui/ScreenSpaceWorldLocators")]
	public class ScreenSpaceWorldLocators : MonoBehaviour
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x3390390", Offset = "0x338E990", VA = "0x183390390")]
		private void LateUpdate()
		{
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x3390A90", Offset = "0x338F090", VA = "0x183390A90")]
		private Camera GetCamera()
		{
			return null;
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x3390BE0", Offset = "0x338F1E0", VA = "0x183390BE0")]
		public ScreenSpaceWorldLocators()
		{
		}

		// Token: 0x04002104 RID: 8452
		[Token(Token = "0x4002104")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _uiMarker;

		// Token: 0x04002105 RID: 8453
		[Token(Token = "0x4002105")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _parentTransform;

		// Token: 0x04002106 RID: 8454
		[Token(Token = "0x4002106")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _alwaysShowOnScreen;

		// Token: 0x04002107 RID: 8455
		[Token(Token = "0x4002107")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _screenPaddingX;

		// Token: 0x04002108 RID: 8456
		[Token(Token = "0x4002108")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _screenPaddingY;

		// Token: 0x04002109 RID: 8457
		[Token(Token = "0x4002109")]
		[FieldOffset(Offset = "0x40")]
		private Camera _cachedCamera;
	}
}
