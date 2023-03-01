using System;
using Il2CppDummyDll;
using PathCreation;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay
{
	// Token: 0x0200063C RID: 1596
	[Token(Token = "0x200063C")]
	[AddComponentMenu("Sons/Gameplay/Drinkable Water Path")]
	public class DrinkableWaterPath : MonoBehaviour
	{
		// Token: 0x06002909 RID: 10505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002909")]
		[Address(RVA = "0x2DB61E0", Offset = "0x2DB51E0", VA = "0x182DB61E0")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290A")]
		[Address(RVA = "0x2DB6230", Offset = "0x2DB5230", VA = "0x182DB6230")]
		private void Update()
		{
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290B")]
		[Address(RVA = "0x2DB6160", Offset = "0x2DB5160", VA = "0x182DB6160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600290C")]
		[Address(RVA = "0x2DB64D0", Offset = "0x2DB54D0", VA = "0x182DB64D0")]
		public DrinkableWaterPath()
		{
		}

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		private const string PlayerTag = "Player";

		// Token: 0x040024AC RID: 9388
		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PathCreator _pathCreator;

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_drinkableWaterNode")]
		private InteractableWaterNode _interactableWaterNode;

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _nodeActivationAngle;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _nodeActivationRange;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _boundsRadius;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _closestPosition;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("Json Source")]
		private string _jsonPathData;
	}
}
