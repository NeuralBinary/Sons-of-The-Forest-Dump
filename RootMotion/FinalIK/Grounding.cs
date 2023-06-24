using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Serializable]
	public class Grounding
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public Grounding.Leg[] legs
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001B")]
		public Grounding.Pelvis pelvis
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002E4C File Offset: 0x0000104C
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001C")]
		public bool isGrounded
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001D")]
		public Transform root
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002E64 File Offset: 0x00001064
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2909670", Offset = "0x2907C70", VA = "0x182909670")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x29096A0", Offset = "0x2907CA0", VA = "0x1829096A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x1700001F")]
		public bool rootGrounded
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x29096D0", Offset = "0x2907CD0", VA = "0x1829096D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x29096F0", Offset = "0x2907CF0", VA = "0x1829096F0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2909C90", Offset = "0x2908290", VA = "0x182909C90")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2909ED0", Offset = "0x29084D0", VA = "0x182909ED0")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x290A5A0", Offset = "0x2908BA0", VA = "0x18290A5A0")]
		public void Update()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x290A7F0", Offset = "0x2908DF0", VA = "0x18290A7F0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x290AB50", Offset = "0x2909150", VA = "0x18290AB50")]
		public void Reset()
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x290AF20", Offset = "0x2909520", VA = "0x18290AF20")]
		public void LogWarning(string message)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x17000020")]
		public Vector3 up
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x290AF40", Offset = "0x2909540", VA = "0x18290AF40")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x290AFD0", Offset = "0x29095D0", VA = "0x18290AFD0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return 0f;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x290B170", Offset = "0x2909770", VA = "0x18290B170")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x17000021")]
		private bool useRootRotation
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x290B2A0", Offset = "0x29098A0", VA = "0x18290B2A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x290B370", Offset = "0x2909970", VA = "0x18290B370")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x290B480", Offset = "0x2909A80", VA = "0x18290B480")]
		public Grounding()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[Tooltip("Offset of the foot center along character forward axis.")]
		public float footCenterOffset;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		public float footRotationWeight;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 90f)]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		public float maxFootRotationAngle;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Grounding.Quality quality;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xA4")]
		private bool initiated;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		[Serializable]
		public enum Quality
		{
			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			Fastest,
			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			Simple,
			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			Best
		}

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public class Leg
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002F54 File Offset: 0x00001154
			// (set) Token: 0x060001CA RID: 458 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000022")]
			public bool isGrounded
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x5FD4E0", Offset = "0x5FBAE0", VA = "0x1805FD4E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CA")]
				[Address(RVA = "0x5FD4F0", Offset = "0x5FBAF0", VA = "0x1805FD4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060001CB RID: 459 RVA: 0x00002F6C File Offset: 0x0000116C
			// (set) Token: 0x060001CC RID: 460 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000023")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60001CB")]
				[Address(RVA = "0xAA8B50", Offset = "0xAA7150", VA = "0x180AA8B50")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001CC")]
				[Address(RVA = "0x290B4E0", Offset = "0x2909AE0", VA = "0x18290B4E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060001CD RID: 461 RVA: 0x00002F84 File Offset: 0x00001184
			// (set) Token: 0x060001CE RID: 462 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000024")]
			public bool initiated
			{
				[Token(Token = "0x60001CD")]
				[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60001CE")]
				[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00002F9C File Offset: 0x0000119C
			// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000025")]
			public float heightFromGround
			{
				[Token(Token = "0x60001CF")]
				[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60001D0")]
				[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002FB4 File Offset: 0x000011B4
			// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000026")]
			public Vector3 velocity
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x26ECB30", Offset = "0x26EB130", VA = "0x1826ECB30")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x290B4F0", Offset = "0x2909AF0", VA = "0x18290B4F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000027")]
			public Transform transform
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002FCC File Offset: 0x000011CC
			// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000028")]
			public float IKOffset
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x23A8BF0", Offset = "0x23A71F0", VA = "0x1823A8BF0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x290B500", Offset = "0x2909B00", VA = "0x18290B500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002FE4 File Offset: 0x000011E4
			// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000029")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x290B510", Offset = "0x2909B10", VA = "0x18290B510")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x290B540", Offset = "0x2909B40", VA = "0x18290B540")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x00002FFC File Offset: 0x000011FC
			// (set) Token: 0x060001DA RID: 474 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700002A")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x290B570", Offset = "0x2909B70", VA = "0x18290B570")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60001DA")]
				[Address(RVA = "0x290B5A0", Offset = "0x2909BA0", VA = "0x18290B5A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00003014 File Offset: 0x00001214
			[Token(Token = "0x1700002B")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60001DB")]
				[Address(RVA = "0x290B5D0", Offset = "0x2909BD0", VA = "0x18290B5D0")]
				get
				{
					return default(RaycastHit);
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x290B650", Offset = "0x2909C50", VA = "0x18290B650")]
			public void SetFootPosition(Vector3 position)
			{
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x290B670", Offset = "0x2909C70", VA = "0x18290B670")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			// Token: 0x060001DE RID: 478 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x290B900", Offset = "0x2909F00", VA = "0x18290B900")]
			public void OnEnable()
			{
			}

			// Token: 0x060001DF RID: 479 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x290B9F0", Offset = "0x2909FF0", VA = "0x18290B9F0")]
			public void Reset()
			{
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x290BB80", Offset = "0x290A180", VA = "0x18290BB80")]
			public void Process()
			{
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000302C File Offset: 0x0000122C
			[Token(Token = "0x1700002C")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60001E1")]
				[Address(RVA = "0x290CA60", Offset = "0x290B060", VA = "0x18290CA60")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00003044 File Offset: 0x00001244
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x290CAB0", Offset = "0x290B0B0", VA = "0x18290CAB0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x0000305C File Offset: 0x0000125C
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x290D240", Offset = "0x290B840", VA = "0x18290D240")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00003074 File Offset: 0x00001274
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x290D760", Offset = "0x290BD60", VA = "0x18290D760")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x290D880", Offset = "0x290BE80", VA = "0x18290D880")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x290D990", Offset = "0x290BF90", VA = "0x18290D990")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0000308C File Offset: 0x0000128C
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x290DDA0", Offset = "0x290C3A0", VA = "0x18290DDA0")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return 0f;
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x290DF60", Offset = "0x290C560", VA = "0x18290DF60")]
			private void RotateFoot()
			{
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x000030A4 File Offset: 0x000012A4
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x290E0E0", Offset = "0x290C6E0", VA = "0x18290E0E0")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x060001EA RID: 490 RVA: 0x000030BC File Offset: 0x000012BC
			[Token(Token = "0x1700002D")]
			private float rootYOffset
			{
				[Token(Token = "0x60001EA")]
				[Address(RVA = "0x290E200", Offset = "0x290C800", VA = "0x18290E200")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060001EB RID: 491 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x290E360", Offset = "0x290C960", VA = "0x18290E360")]
			public Leg()
			{
			}

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			// Token: 0x04000192 RID: 402
			[Token(Token = "0x4000192")]
			[FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			// Token: 0x04000195 RID: 405
			[Token(Token = "0x4000195")]
			[FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0xB8")]
			private float lastTime;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			// Token: 0x0400019A RID: 410
			[Token(Token = "0x400019A")]
			[FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			// Token: 0x0400019B RID: 411
			[Token(Token = "0x400019B")]
			[FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			// Token: 0x0400019C RID: 412
			[Token(Token = "0x400019C")]
			[FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			// Token: 0x0400019D RID: 413
			[Token(Token = "0x400019D")]
			[FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			// Token: 0x0400019E RID: 414
			[Token(Token = "0x400019E")]
			[FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;
		}

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public class Pelvis
		{
			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060001EC RID: 492 RVA: 0x000030D4 File Offset: 0x000012D4
			// (set) Token: 0x060001ED RID: 493 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700002E")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60001EC")]
				[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60001ED")]
				[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060001EE RID: 494 RVA: 0x000030EC File Offset: 0x000012EC
			// (set) Token: 0x060001EF RID: 495 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700002F")]
			public float heightOffset
			{
				[Token(Token = "0x60001EE")]
				[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60001EF")]
				[Address(RVA = "0x26F9F30", Offset = "0x26F8530", VA = "0x1826F9F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x290E3E0", Offset = "0x290C9E0", VA = "0x18290E3E0")]
			public void Initiate(Grounding grounding)
			{
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x290E560", Offset = "0x290CB60", VA = "0x18290E560")]
			public void Reset()
			{
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x290E6E0", Offset = "0x290CCE0", VA = "0x18290E6E0")]
			public void OnEnable()
			{
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x290E820", Offset = "0x290CE20", VA = "0x18290E820")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Pelvis()
			{
			}

			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			[FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			[FieldOffset(Offset = "0x34")]
			private float damperF;

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0x38")]
			private bool initiated;

			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0x3C")]
			private float lastTime;
		}
	}
}
