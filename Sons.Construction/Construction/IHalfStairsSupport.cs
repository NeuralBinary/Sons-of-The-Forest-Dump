using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	public interface IHalfStairsSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CF4 RID: 3316
		[Token(Token = "0x6000CF4")]
		int CalcMaxElements();

		// Token: 0x06000CF5 RID: 3317
		[Token(Token = "0x6000CF5")]
		Vector3 CalcHalfStairsOffsetFromSupport(StructureElement halfStairsElementPrefab, Directions sideDir);

		// Token: 0x06000CF6 RID: 3318
		[Token(Token = "0x6000CF6")]
		void SetHalfStairsAtDir(Directions support1Direction, HalfStairsStructure halfStairsC);

		// Token: 0x06000CF7 RID: 3319
		[Token(Token = "0x6000CF7")]
		bool TryGetHalfStairsAtDir(Directions direction, out HalfStairsStructure halfStairs);

		// Token: 0x06000CF8 RID: 3320
		[Token(Token = "0x6000CF8")]
		bool HasHalfStairsAtDir(Directions direction);

		// Token: 0x06000CF9 RID: 3321
		[Token(Token = "0x6000CF9")]
		bool TryCalcBottomStairsOptions(Directions halfStairsDirection, Directions diagonalDirBottom, out bool isBottomStairs);

		// Token: 0x06000CFA RID: 3322
		[Token(Token = "0x6000CFA")]
		bool CalcCurvedStairsOptions(Directions sideDir, Directions bottomEndDir, out IHalfStairsSupport cornerSupport, out Directions cornerWallDir);
	}
}
