using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class DroppedBagUiMarker : MonoBehaviour
	{
		// Token: 0x06002A67 RID: 10855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A67")]
		[Address(RVA = "0x2DC7370", Offset = "0x2DC6370", VA = "0x182DC7370")]
		private void Update()
		{
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A68")]
		[Address(RVA = "0x2DC7010", Offset = "0x2DC6010", VA = "0x182DC7010")]
		private void OnDisable()
		{
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x6002A69")]
		[Address(RVA = "0x2DC6F50", Offset = "0x2DC5F50", VA = "0x182DC6F50")]
		private static bool IsInFront(Transform viewTransform, Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6A")]
		[Address(RVA = "0x2DC71B0", Offset = "0x2DC61B0", VA = "0x182DC71B0")]
		private void ShowElement(Vector3 position, Transform targetTransform)
		{
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6B")]
		[Address(RVA = "0x2DC7020", Offset = "0x2DC6020", VA = "0x182DC7020")]
		private void RemoveElement()
		{
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x6002A6C")]
		[Address(RVA = "0x2DC70B0", Offset = "0x2DC60B0", VA = "0x182DC70B0")]
		private bool RequestUiElement()
		{
			return default(bool);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A6D")]
		[Address(RVA = "0x2DC7670", Offset = "0x2DC6670", VA = "0x182DC7670")]
		public DroppedBagUiMarker()
		{
		}

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _uiElementId;

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		[FieldOffset(Offset = "0x28")]
		private string _cachedUiElementId;

		// Token: 0x040025DC RID: 9692
		[Token(Token = "0x40025DC")]
		[FieldOffset(Offset = "0x30")]
		private int _uiElementIdHash;

		// Token: 0x040025DD RID: 9693
		[Token(Token = "0x40025DD")]
		[FieldOffset(Offset = "0x38")]
		private GameObject _uiGameObject;
	}
}
