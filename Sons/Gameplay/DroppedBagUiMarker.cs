using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class DroppedBagUiMarker : MonoBehaviour
	{
		// Token: 0x0600346F RID: 13423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x34CA370", Offset = "0x34C8970", VA = "0x1834CA370")]
		private void Update()
		{
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003470")]
		[Address(RVA = "0x34CA800", Offset = "0x34C8E00", VA = "0x1834CA800")]
		private void OnDisable()
		{
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0000FA98 File Offset: 0x0000DC98
		[Token(Token = "0x6003471")]
		[Address(RVA = "0x34CA810", Offset = "0x34C8E10", VA = "0x1834CA810")]
		private static bool IsInFront(Transform viewTransform, Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x34CA910", Offset = "0x34C8F10", VA = "0x1834CA910")]
		private void ShowElement(Vector3 position, Transform targetTransform)
		{
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x34CAAA0", Offset = "0x34C90A0", VA = "0x1834CAAA0")]
		private void RemoveElement()
		{
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x6003474")]
		[Address(RVA = "0x34CABD0", Offset = "0x34C91D0", VA = "0x1834CABD0")]
		private bool RequestUiElement()
		{
			return default(bool);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x34CAEB0", Offset = "0x34C94B0", VA = "0x1834CAEB0")]
		public DroppedBagUiMarker()
		{
		}

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _uiElementId;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0x28")]
		private string _cachedUiElementId;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x30")]
		private int _uiElementIdHash;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _uiGameObject;
	}
}
