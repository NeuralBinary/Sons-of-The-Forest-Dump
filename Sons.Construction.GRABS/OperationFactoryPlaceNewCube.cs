using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: PlaceNewCube", fileName = "GRABS OperationFactory - PlaceNewCube")]
	public class OperationFactoryPlaceNewCube : OperationFactory
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2D9EC90", Offset = "0x2D9D290", VA = "0x182D9EC90", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2D9FED0", Offset = "0x2D9E4D0", VA = "0x182D9FED0")]
		private void Init(BlueprintFace face)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryPlaceNewCube()
		{
		}

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Archetype _sideArchetype;
	}
}
