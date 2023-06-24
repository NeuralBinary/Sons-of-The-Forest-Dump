using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public abstract class ObiActor : MonoBehaviour, IObiParticleCollection
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001EA RID: 490 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001EB RID: 491 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000003")]
		public event ObiActor.ActorBlueprintCallback OnBlueprintLoaded
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x275A090", Offset = "0x2758690", VA = "0x18275A090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x275A180", Offset = "0x2758780", VA = "0x18275A180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001EC RID: 492 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001ED RID: 493 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000004")]
		public event ObiActor.ActorBlueprintCallback OnBlueprintUnloaded
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x275A270", Offset = "0x2758870", VA = "0x18275A270")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x275A360", Offset = "0x2758960", VA = "0x18275A360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001EE RID: 494 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000005")]
		public event ObiActor.ActorStepCallback OnPrepareStep
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x275A450", Offset = "0x2758A50", VA = "0x18275A450")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x275A540", Offset = "0x2758B40", VA = "0x18275A540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001F0 RID: 496 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001F1 RID: 497 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000006")]
		public event ObiActor.ActorStepCallback OnBeginStep
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x275A630", Offset = "0x2758C30", VA = "0x18275A630")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x275A720", Offset = "0x2758D20", VA = "0x18275A720")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060001F2 RID: 498 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001F3 RID: 499 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000007")]
		public event ObiActor.ActorStepCallback OnSubstep
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x275A810", Offset = "0x2758E10", VA = "0x18275A810")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x275A900", Offset = "0x2758F00", VA = "0x18275A900")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001F4 RID: 500 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001F5 RID: 501 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000008")]
		public event ObiActor.ActorStepCallback OnEndStep
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x275A9F0", Offset = "0x2758FF0", VA = "0x18275A9F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x275AAE0", Offset = "0x27590E0", VA = "0x18275AAE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060001F6 RID: 502 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060001F7 RID: 503 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000009")]
		public event ObiActor.ActorCallback OnInterpolate
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x275ABD0", Offset = "0x27591D0", VA = "0x18275ABD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x275ACC0", Offset = "0x27592C0", VA = "0x18275ACC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700005C")]
		public ObiSolver solver
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002834 File Offset: 0x00000A34
		[Token(Token = "0x1700005D")]
		public bool isLoaded
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700005E")]
		public ObiCollisionMaterial collisionMaterial
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x275ADB0", Offset = "0x27593B0", VA = "0x18275ADB0")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700005F")]
		public virtual bool surfaceCollisions
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x275AF30", Offset = "0x2759530", VA = "0x18275AF30", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x17000060")]
		public int particleCount
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x275B020", Offset = "0x2759620", VA = "0x18275B020", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x17000061")]
		public int activeParticleCount
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002894 File Offset: 0x00000A94
		[Token(Token = "0x17000062")]
		public bool usesOrientedParticles
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x275B130", Offset = "0x2759730", VA = "0x18275B130", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000201 RID: 513 RVA: 0x000028AC File Offset: 0x00000AAC
		[Token(Token = "0x17000063")]
		public virtual bool usesAnisotropicParticles
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000028C4 File Offset: 0x00000AC4
		[Token(Token = "0x17000064")]
		public virtual bool usesCustomExternalForces
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000028DC File Offset: 0x00000ADC
		[Token(Token = "0x17000065")]
		public Matrix4x4 actorLocalToSolverMatrix
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x275B330", Offset = "0x2759930", VA = "0x18275B330")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000204 RID: 516 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x17000066")]
		public Matrix4x4 actorSolverToLocalMatrix
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x275B6C0", Offset = "0x2759CC0", VA = "0x18275B6C0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000205 RID: 517
		[Token(Token = "0x17000067")]
		public abstract ObiActorBlueprint sourceBlueprint { [Token(Token = "0x6000205")] get; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000068")]
		public ObiActorBlueprint sharedBlueprint
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x275BA50", Offset = "0x275A050", VA = "0x18275BA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000069")]
		public ObiActorBlueprint blueprint
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x275BB40", Offset = "0x275A140", VA = "0x18275BB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x275BD50", Offset = "0x275A350", VA = "0x18275BD50")]
		protected void Awake()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x275C0C0", Offset = "0x275A6C0", VA = "0x18275C0C0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x275C1B0", Offset = "0x275A7B0", VA = "0x18275C1B0", Slot = "18")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x275C250", Offset = "0x275A850", VA = "0x18275C250", Slot = "19")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x275C260", Offset = "0x275A860", VA = "0x18275C260")]
		private void OnTransformParentChanged()
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x275C450", Offset = "0x275AA50", VA = "0x18275C450")]
		public void AddToSolver()
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x275C780", Offset = "0x275AD80", VA = "0x18275C780")]
		public void RemoveFromSolver()
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x275CA40", Offset = "0x275B040", VA = "0x18275CA40")]
		protected void SetSolver(ObiSolver newSolver)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x275CBC0", Offset = "0x275B1C0", VA = "0x18275CBC0", Slot = "21")]
		protected virtual void OnBlueprintRegenerate(ObiActorBlueprint blueprint)
		{
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x275CBE0", Offset = "0x275B1E0", VA = "0x18275CBE0")]
		protected void UpdateCollisionMaterials()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x275CFE0", Offset = "0x275B5E0", VA = "0x18275CFE0", Slot = "22")]
		public virtual bool CopyParticle(int actorSourceIndex, int actorDestIndex)
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x275D690", Offset = "0x275BC90", VA = "0x18275D690")]
		public void TeleportParticle(int actorIndex, Vector3 position)
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x275DA10", Offset = "0x275C010", VA = "0x18275DA10", Slot = "23")]
		public virtual void Teleport(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x275F220", Offset = "0x275D820", VA = "0x18275F220", Slot = "24")]
		protected virtual void SwapWithFirstInactiveParticle(int actorIndex)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x275F390", Offset = "0x275D990", VA = "0x18275F390")]
		public bool ActivateParticle(int actorIndex)
		{
			return default(bool);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x275F3E0", Offset = "0x275D9E0", VA = "0x18275F3E0")]
		public bool DeactivateParticle(int actorIndex)
		{
			return default(bool);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x275F430", Offset = "0x275DA30", VA = "0x18275F430")]
		public bool IsParticleActive(int actorIndex)
		{
			return default(bool);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x275F440", Offset = "0x275DA40", VA = "0x18275F440", Slot = "25")]
		public virtual void SetSelfCollisions(bool selfCollisions)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x275F680", Offset = "0x275DC80", VA = "0x18275F680", Slot = "26")]
		public virtual void SetOneSided(bool oneSided)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x275F8C0", Offset = "0x275DEC0", VA = "0x18275F8C0")]
		public void SetSimplicesDirty()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x275F9A0", Offset = "0x275DFA0", VA = "0x18275F9A0")]
		public void SetConstraintsDirty(Oni.ConstraintType constraintType)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x275FA90", Offset = "0x275E090", VA = "0x18275FA90")]
		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		public virtual void UpdateParticleProperties()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x275FCE0", Offset = "0x275E2E0", VA = "0x18275FCE0", Slot = "7")]
		public int GetParticleRuntimeIndex(int actorIndex)
		{
			return 0;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x275FD20", Offset = "0x275E320", VA = "0x18275FD20", Slot = "8")]
		public Vector3 GetParticlePosition(int solverIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x275FEF0", Offset = "0x275E4F0", VA = "0x18275FEF0", Slot = "9")]
		public Quaternion GetParticleOrientation(int solverIndex)
		{
			return default(Quaternion);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2760090", Offset = "0x275E690", VA = "0x182760090", Slot = "10")]
		public void GetParticleAnisotropy(int solverIndex, ref Vector4 b1, ref Vector4 b2, ref Vector4 b3)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2760630", Offset = "0x275EC30", VA = "0x182760630", Slot = "11")]
		public float GetParticleMaxRadius(int solverIndex)
		{
			return 0f;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x27606C0", Offset = "0x275ECC0", VA = "0x1827606C0", Slot = "12")]
		public Color GetParticleColor(int solverIndex)
		{
			return default(Color);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2760740", Offset = "0x275ED40", VA = "0x182760740")]
		public void SetPhase(int newPhase)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2760A50", Offset = "0x275F050", VA = "0x182760A50")]
		public void SetMass(float mass)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2760F80", Offset = "0x275F580", VA = "0x182760F80")]
		public float GetMass(out Vector3 com)
		{
			return 0f;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2761300", Offset = "0x275F900", VA = "0x182761300")]
		public void AddForce(Vector3 force, ForceMode forceMode)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2762030", Offset = "0x2760630", VA = "0x182762030")]
		public void AddTorque(Vector3 force, ForceMode forceMode)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2762F00", Offset = "0x2761500", VA = "0x182762F00")]
		private void LoadBlueprintParticles(ObiActorBlueprint bp)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2763B30", Offset = "0x2762130", VA = "0x182763B30")]
		private void UnloadBlueprintParticles()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2763B70", Offset = "0x2762170", VA = "0x182763B70")]
		public void ResetParticles()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x27644F0", Offset = "0x2762AF0", VA = "0x1827644F0")]
		public void SaveStateToBlueprint(ObiActorBlueprint bp)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x27649D0", Offset = "0x2762FD0", VA = "0x1827649D0")]
		protected void StoreState()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2764AD0", Offset = "0x27630D0", VA = "0x182764AD0")]
		public void ClearState()
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2764B20", Offset = "0x2763120", VA = "0x182764B20", Slot = "28")]
		public virtual void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2764CD0", Offset = "0x27632D0", VA = "0x182764CD0", Slot = "29")]
		public virtual void UnloadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2764EB0", Offset = "0x27634B0", VA = "0x182764EB0", Slot = "30")]
		public virtual void PrepareStep(float stepTime)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2764EF0", Offset = "0x27634F0", VA = "0x182764EF0", Slot = "31")]
		public virtual void BeginStep(float stepTime)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2764F10", Offset = "0x2763510", VA = "0x182764F10", Slot = "32")]
		public virtual void Substep(float substepTime)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2764F30", Offset = "0x2763530", VA = "0x182764F30", Slot = "33")]
		public virtual void EndStep(float substepTime)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2764F50", Offset = "0x2763550", VA = "0x182764F50", Slot = "34")]
		public virtual void Interpolate()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "35")]
		public virtual void OnSolverVisibilityChanged(bool visible)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected ObiActor()
		{
		}

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[NonSerialized]
		protected int m_ActiveParticleCount;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[NonSerialized]
		public int[] solverIndices;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x68")]
		[HideInInspector]
		[NonSerialized]
		public List<int>[] solverBatchOffsets;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x70")]
		protected ObiSolver m_Solver;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x78")]
		protected bool m_Loaded;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x80")]
		private ObiActorBlueprint state;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x88")]
		private ObiActorBlueprint m_BlueprintInstance;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x90")]
		private ObiPinConstraintsData m_PinConstraints;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		protected ObiCollisionMaterial m_CollisionMaterial;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		[SerializeField]
		protected bool m_SurfaceCollisions;

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		public class ObiActorSolverArgs : EventArgs
		{
			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600023A RID: 570 RVA: 0x00002186 File Offset: 0x00000386
			[Token(Token = "0x1700006A")]
			public ObiSolver solver
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600023B RID: 571 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x27654A0", Offset = "0x2763AA0", VA = "0x1827654A0")]
			public ObiActorSolverArgs(ObiSolver solver)
			{
			}
		}

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x0600023D RID: 573
		[Token(Token = "0x2000047")]
		public delegate void ActorCallback(ObiActor actor);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000241 RID: 577
		[Token(Token = "0x2000048")]
		public delegate void ActorStepCallback(ObiActor actor, float stepTime);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000245 RID: 581
		[Token(Token = "0x2000049")]
		public delegate void ActorBlueprintCallback(ObiActor actor, ObiActorBlueprint blueprint);
	}
}
