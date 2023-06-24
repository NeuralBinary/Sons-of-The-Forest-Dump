using System;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	[AddComponentMenu("Sons/Gameplay/Drinkable Water Path")]
	public class DrinkableWaterPath : MonoBehaviour
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E8")]
		[Address(RVA = "0x34ACF90", Offset = "0x34AB590", VA = "0x1834ACF90")]
		private void OnPostRender()
		{
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032E9")]
		[Address(RVA = "0x34AD060", Offset = "0x34AB660", VA = "0x1834AD060")]
		private void Update()
		{
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032EA")]
		[Address(RVA = "0x34AD490", Offset = "0x34ABA90", VA = "0x1834AD490")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032EB")]
		[Address(RVA = "0x34AD610", Offset = "0x34ABC10", VA = "0x1834AD610")]
		public DrinkableWaterPath()
		{
		}

		// Token: 0x04002BEF RID: 11247
		[Token(Token = "0x4002BEF")]
		private const string PlayerTag = "Player";

		// Token: 0x04002BF0 RID: 11248
		[Token(Token = "0x4002BF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PathCreator _pathCreator;

		// Token: 0x04002BF1 RID: 11249
		[Token(Token = "0x4002BF1")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_drinkableWaterNode")]
		[SerializeField]
		private InteractableWaterNode _interactableWaterNode;

		// Token: 0x04002BF2 RID: 11250
		[Token(Token = "0x4002BF2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _nodeActivationAngle;

		// Token: 0x04002BF3 RID: 11251
		[Token(Token = "0x4002BF3")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nodeActivationRange;

		// Token: 0x04002BF4 RID: 11252
		[Token(Token = "0x4002BF4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _boundsRadius;

		// Token: 0x04002BF5 RID: 11253
		[Token(Token = "0x4002BF5")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _closestPosition;

		// Token: 0x04002BF6 RID: 11254
		[Token(Token = "0x4002BF6")]
		[FieldOffset(Offset = "0x48")]
		[Header("Json Source")]
		[SerializeField]
		private string _jsonPathData;
	}
}
