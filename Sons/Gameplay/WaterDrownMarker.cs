using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200080A RID: 2058
	[Token(Token = "0x200080A")]
	[AddComponentMenu("Sons/GamePlay/WaterDrownMarker")]
	public class WaterDrownMarker : MonoBehaviour
	{
		// Token: 0x06003774 RID: 14196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x353F510", Offset = "0x353DB10", VA = "0x18353F510")]
		private void OnEnable()
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x353F730", Offset = "0x353DD30", VA = "0x18353F730")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x353F8A0", Offset = "0x353DEA0", VA = "0x18353F8A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003777 RID: 14199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003777")]
		[Address(RVA = "0x353F8B0", Offset = "0x353DEB0", VA = "0x18353F8B0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003778 RID: 14200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003778")]
		[Address(RVA = "0x353F8C0", Offset = "0x353DEC0", VA = "0x18353F8C0")]
		private void ValidateMarkerId()
		{
		}

		// Token: 0x06003779 RID: 14201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003779")]
		[Address(RVA = "0x353F940", Offset = "0x353DF40", VA = "0x18353F940")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377A")]
		[Address(RVA = "0x3540120", Offset = "0x353E720", VA = "0x183540120")]
		public static void LogSelected(GameObject sourceGameObject)
		{
		}

		// Token: 0x0600377B RID: 14203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600377B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public WaterDrownMarker()
		{
		}

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _snapOffset;

		// Token: 0x04002FDE RID: 12254
		[Token(Token = "0x4002FDE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _tiltUsingSnapOffset;

		// Token: 0x04002FDF RID: 12255
		[Token(Token = "0x4002FDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _markerIdIntegers;

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _markerId;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x40")]
		private int _instanceId;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static Dictionary<string, int> _registeredMarkerIds;

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x44")]
		[NonSerialized]
		private bool _validatedMarkerId;
	}
}
