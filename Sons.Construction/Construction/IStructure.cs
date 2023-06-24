using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001BD RID: 445
	[Token(Token = "0x20001BD")]
	public interface IStructure : IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000D13 RID: 3347
		[Token(Token = "0x17000320")]
		ushort TypeID { [Token(Token = "0x6000D13")] get; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000D14 RID: 3348
		[Token(Token = "0x17000321")]
		uint InstanceID { [Token(Token = "0x6000D14")] get; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000D15 RID: 3349
		[Token(Token = "0x17000322")]
		int LinkedStructureCount { [Token(Token = "0x6000D15")] get; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000D16 RID: 3350
		[Token(Token = "0x17000323")]
		string name { [Token(Token = "0x6000D16")] get; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000D17 RID: 3351
		[Token(Token = "0x17000324")]
		Directions[] Supporting { [Token(Token = "0x6000D17")] get; }

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000D18 RID: 3352
		[Token(Token = "0x17000325")]
		Directions[] SupportedBy { [Token(Token = "0x6000D18")] get; }

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000D19 RID: 3353
		[Token(Token = "0x17000326")]
		Transform ElementRoot { [Token(Token = "0x6000D19")] get; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000D1A RID: 3354
		[Token(Token = "0x17000327")]
		bool AllowSuperStructureMerge { [Token(Token = "0x6000D1A")] get; }

		// Token: 0x06000D1B RID: 3355
		[Token(Token = "0x6000D1B")]
		int CountElements();

		// Token: 0x06000D1C RID: 3356
		[Token(Token = "0x6000D1C")]
		bool IsCompleted();

		// Token: 0x06000D1D RID: 3357
		[Token(Token = "0x6000D1D")]
		bool HasStructureAtDir(Directions dir);

		// Token: 0x06000D1E RID: 3358
		[Token(Token = "0x6000D1E")]
		bool HasStructureAtDir<T>(Directions dir) where T : class, IStructure;

		// Token: 0x06000D1F RID: 3359
		[Token(Token = "0x6000D1F")]
		Structure GetStructureAtDir(Directions dir);

		// Token: 0x06000D20 RID: 3360
		[Token(Token = "0x6000D20")]
		T GetStructureAtDir<T>(Directions direction) where T : class, IStructure;

		// Token: 0x06000D21 RID: 3361
		[Token(Token = "0x6000D21")]
		T GetStructureAtDir<T>(int direction) where T : class, IStructure;

		// Token: 0x06000D22 RID: 3362
		[Token(Token = "0x6000D22")]
		bool TryGetStructureAtDir(Directions dir, out IStructure structure);

		// Token: 0x06000D23 RID: 3363
		[Token(Token = "0x6000D23")]
		bool TryGetStructureAtDir<T>(Directions direction, out T structure) where T : class, IStructure;

		// Token: 0x06000D24 RID: 3364
		[Token(Token = "0x6000D24")]
		void SetStructureAtDir(int direction, IStructure structure);

		// Token: 0x06000D25 RID: 3365
		[Token(Token = "0x6000D25")]
		void SetStructureAtDir(Directions direction, IStructure structure);

		// Token: 0x06000D26 RID: 3366
		[Token(Token = "0x6000D26")]
		bool TryGetStructureDir(IStructure structure, out Directions dir);

		// Token: 0x06000D27 RID: 3367
		[Token(Token = "0x6000D27")]
		bool TryGetStructureDirNum(IStructure structure, out int dir);

		// Token: 0x06000D28 RID: 3368
		[Token(Token = "0x6000D28")]
		bool IsSupportedByAny();

		// Token: 0x06000D29 RID: 3369
		[Token(Token = "0x6000D29")]
		bool IsSupportedBy(IStructure structure, out bool hasFallback);

		// Token: 0x06000D2A RID: 3370
		[Token(Token = "0x6000D2A")]
		bool IsSupportingStructure([Optional] IStructure exceptStructure, bool allowFallbacks = true);

		// Token: 0x06000D2B RID: 3371
		[Token(Token = "0x6000D2B")]
		bool IsMissingSupport();

		// Token: 0x06000D2C RID: 3372
		[Token(Token = "0x6000D2C")]
		Quaternion CalcNextElementRotation(StructureElement elementPrefab);

		// Token: 0x06000D2D RID: 3373
		[Token(Token = "0x6000D2D")]
		Vector3 CalcNextElementPosition(StructureElement elementPrefab);

		// Token: 0x06000D2E RID: 3374
		[Token(Token = "0x6000D2E")]
		Vector3 CalcElementPosition(StructureElement elementPrefab, int i);

		// Token: 0x06000D2F RID: 3375
		[Token(Token = "0x6000D2F")]
		int CalcNextElementNumber();

		// Token: 0x06000D30 RID: 3376
		[Token(Token = "0x6000D30")]
		StructureElement GetFirstElement();

		// Token: 0x06000D31 RID: 3377
		[Token(Token = "0x6000D31")]
		StructureElement GetLastElement();

		// Token: 0x06000D32 RID: 3378
		[Token(Token = "0x6000D32")]
		float CalcTopHeight();

		// Token: 0x06000D33 RID: 3379
		[Token(Token = "0x6000D33")]
		float CalcBottomHeight();

		// Token: 0x06000D34 RID: 3380
		[Token(Token = "0x6000D34")]
		void ReplaceLinkedStructure(IStructure from, IStructure to);

		// Token: 0x06000D35 RID: 3381
		[Token(Token = "0x6000D35")]
		void SwapStructures(Directions from, Directions to);

		// Token: 0x06000D36 RID: 3382
		[Token(Token = "0x6000D36")]
		RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim);

		// Token: 0x06000D37 RID: 3383
		[Token(Token = "0x6000D37")]
		StructureElement GetNthElement(int elementNum);

		// Token: 0x06000D38 RID: 3384
		[Token(Token = "0x6000D38")]
		void OnPostLoad();
	}
}
