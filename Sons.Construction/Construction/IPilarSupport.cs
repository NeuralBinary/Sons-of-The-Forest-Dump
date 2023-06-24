using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public interface IPilarSupport : IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x06000CFC RID: 3324
		[Token(Token = "0x6000CFC")]
		bool CanHostNewPilar(bool advancedBuildMode);

		// Token: 0x06000CFD RID: 3325
		[Token(Token = "0x6000CFD")]
		bool HasPilarAtDir(Directions dir);

		// Token: 0x06000CFE RID: 3326
		[Token(Token = "0x6000CFE")]
		void SetPilarAtDir(Directions dir, PilarStructure pilar);

		// Token: 0x06000CFF RID: 3327
		[Token(Token = "0x6000CFF")]
		bool TryGetPilarAtDir(Directions dir, out PilarStructure pilar);

		// Token: 0x06000D00 RID: 3328
		[Token(Token = "0x6000D00")]
		Vector3 GetPilarSnapPos(Vector3 pilarPos);

		// Token: 0x06000D01 RID: 3329
		[Token(Token = "0x6000D01")]
		Vector3 GetPilarSnapPos(Directions targetDir);

		// Token: 0x06000D02 RID: 3330
		[Token(Token = "0x6000D02")]
		bool TryGetPilarDir(PilarStructure pilar, out Directions pilarDir);

		// Token: 0x06000D03 RID: 3331
		[Token(Token = "0x6000D03")]
		Directions[] GetAbovePilarDirs();

		// Token: 0x06000D04 RID: 3332
		[Token(Token = "0x6000D04")]
		bool IsBackDir(int dir);

		// Token: 0x06000D05 RID: 3333
		[Token(Token = "0x6000D05")]
		void GetSiblingSupportDirs(bool atBack, out Directions dirFrom, out Directions dirTo);

		// Token: 0x06000D06 RID: 3334
		[Token(Token = "0x6000D06")]
		bool AreSiblingSupportingCrossedWalls(Directions targetDir, bool advancedBuildMode);
	}
}
