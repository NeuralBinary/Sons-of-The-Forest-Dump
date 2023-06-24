using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[CreateAssetMenu(menuName = "Sons/Construction/GRABS/OperationFactory: ExtrudeEdge", fileName = "GRABS OperationFactory - ExtrudeEdge")]
	public class OperationFactoryExtrudeEdge : OperationFactory
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2D9BE40", Offset = "0x2D9A440", VA = "0x182D9BE40", Slot = "4")]
		public override Operation GetOperation(InteractionPoint ip, GrabsController controller)
		{
			return null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2D9C6C0", Offset = "0x2D9ACC0", VA = "0x182D9C6C0")]
		internal static bool TryFindInteractionPoint(BlueprintFace face, float ipToFaceDot, out InteractionPoint foundInteractionPoint)
		{
			return default(bool);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public OperationFactoryExtrudeEdge()
		{
		}

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ExtrudeDir _extrudeAxis;
	}
}
