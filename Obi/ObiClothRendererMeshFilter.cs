using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	[ExecuteInEditMode]
	public abstract class ObiClothRendererMeshFilter : ObiClothRendererBase
	{
		// Token: 0x060001CD RID: 461 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2756CD0", Offset = "0x27552D0", VA = "0x182756CD0", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2756D70", Offset = "0x2755370", VA = "0x182756D70", Slot = "12")]
		protected override void OnBlueprintLoaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2757200", Offset = "0x2755800", VA = "0x182757200", Slot = "13")]
		protected override void OnBlueprintUnloaded(ObiActor actor, ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2754E40", Offset = "0x2753440", VA = "0x182754E40")]
		protected ObiClothRendererMeshFilter()
		{
		}

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xB0")]
		private MeshFilter filter;
	}
}
