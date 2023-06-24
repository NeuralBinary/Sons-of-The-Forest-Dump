using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Utilities;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Areas;
using Sons.Save;
using Sons.StatSystem;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000102 RID: 258
	[Token(Token = "0x2000102")]
	[Serializable]
	public class WorldSimActor : IVailGridObject
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x170000A1")]
		public VailActorTypeId TypeId
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return VailActorTypeId.None;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x170000A2")]
		public VailActorClassId ClassId
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x2B88C80", Offset = "0x2B87280", VA = "0x182B88C80")]
			get
			{
				return VailActorClassId.None;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060009E1 RID: 2529 RVA: 0x00006918 File Offset: 0x00004B18
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A3")]
		public int FamilyId
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x8F47A0", Offset = "0x8F2DA0", VA = "0x1808F47A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x22A59E0", Offset = "0x22A3FE0", VA = "0x1822A59E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x170000A4")]
		public int UniqueId
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x170000A5")]
		public int ActorSeed
		{
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060009E5 RID: 2533 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x170000A6")]
		public int VariationSubSet
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x170000A7")]
		public int VariationId
		{
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x170000A8")]
		public int OutfitId
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x170000A9")]
		public int TickOffset
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x170000AA")]
		public GraphMask NavGraphMask
		{
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
			get
			{
				return default(GraphMask);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000069D8 File Offset: 0x00004BD8
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public bool IsDebugSpawned
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x998F10", Offset = "0x997510", VA = "0x180998F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x000069F0 File Offset: 0x00004BF0
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public bool IsRealActor
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x9EB6D0", Offset = "0x9E9CD0", VA = "0x1809EB6D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x2B88C90", Offset = "0x2B87290", VA = "0x182B88C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x00006A08 File Offset: 0x00004C08
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public float ConvertAttemptTime
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x200ACE0", Offset = "0x20092E0", VA = "0x18200ACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000AE")]
		public IVailSpawner Spawner
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060009F1 RID: 2545 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000AF")]
		public IActorZone CurrentZone
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x170000B0")]
		public State State
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x2B88CA0", Offset = "0x2B872A0", VA = "0x182B88CA0")]
			get
			{
				return default(State);
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x2B88CC0", Offset = "0x2B872C0", VA = "0x182B88CC0")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x2B88D50", Offset = "0x2B87350", VA = "0x182B88D50")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x62AC70", Offset = "0x629270", VA = "0x18062AC70", Slot = "4")]
		public Vector3 Position()
		{
			return default(Vector3);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x2B88D90", Offset = "0x2B87390", VA = "0x182B88D90")]
		public Quaternion Rotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x2B88DA0", Offset = "0x2B873A0", VA = "0x182B88DA0")]
		public void SetState(State state)
		{
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x2B88E70", Offset = "0x2B87470", VA = "0x182B88E70")]
		public bool IsDead()
		{
			return default(bool);
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x170000B1")]
		public AreaMask AreaMask
		{
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0xAFF360", Offset = "0xAFD960", VA = "0x180AFF360")]
			get
			{
				return AreaMask.None;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x170000B2")]
		public bool KeepAboveTerrain
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060009FB RID: 2555 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x170000B3")]
		public bool AlwaysRelevant
		{
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xA50BE0", Offset = "0xA4F1E0", VA = "0x180A50BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x170000B4")]
		public StatsManager StatManager
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x170000B5")]
		public float NextGiftTimeHours
		{
			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x2806050", Offset = "0x2804650", VA = "0x182806050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x2B88EE0", Offset = "0x2B874E0", VA = "0x182B88EE0")]
		public void SetNextGiftTime(float timeInHours)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060009FF RID: 2559 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x170000B6")]
		public float LastVisitTimeHours
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40")]
		public void SetLastVisitTimeHours(float timeInHours)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x2B88EF0", Offset = "0x2B874F0", VA = "0x182B88EF0")]
		public void Spawn(VailActor prefab, Vector3 position, GraphMask graphMask, IVailSpawner spawnedBy, State spawnState, int familyId, int variationId = 0)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x62AC90", Offset = "0x629290", VA = "0x18062AC90")]
		public void SetPosition(Vector3 newPosition)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x2B89630", Offset = "0x2B87C30", VA = "0x182B89630")]
		public void SetRotation(Quaternion newRotation)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x2B89640", Offset = "0x2B87C40", VA = "0x182B89640")]
		public void Teleport(Vector3 newPosition, GraphMask graphMask, AreaMask newAreaMask, IActorZone newZone)
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x2B89800", Offset = "0x2B87E00", VA = "0x182B89800")]
		public bool IsRelevant(Vector3 viewPos, AreaMask viewerAreaMask = AreaMask.None, float extraMargin = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x2B89880", Offset = "0x2B87E80", VA = "0x182B89880")]
		public bool IsRelevantToAny(List<PlayerLocation.ViewerInfo> viewerList, Vector3 actorPosition)
		{
			return default(bool);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x2B89BA0", Offset = "0x2B881A0", VA = "0x182B89BA0")]
		public bool IsRelevant(Vector3 viewPos, Vector3 actorPosition, float extraMargin = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x2B89D40", Offset = "0x2B88340", VA = "0x182B89D40")]
		public int GetDebugOrder()
		{
			return 0;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x2B89D60", Offset = "0x2B88360", VA = "0x182B89D60")]
		public BoundsShape GetWanderBounds()
		{
			return null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x2B89DC0", Offset = "0x2B883C0", VA = "0x182B89DC0")]
		public float TimeInState(float timeInHours)
		{
			return 0f;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0xAFF370", Offset = "0xAFD970", VA = "0x180AFF370")]
		public void SetAreaMask(AreaMask areaMask)
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x14900B0", Offset = "0x148E6B0", VA = "0x1814900B0")]
		public void SetGraphMask(GraphMask graphMask)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x5F2110", Offset = "0x5F0710", VA = "0x1805F2110")]
		public void SetKeepAboveTerrain(bool keepAbove)
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x2B89DD0", Offset = "0x2B883D0", VA = "0x182B89DD0")]
		public void SetLifetimeEnd(float timeInHours)
		{
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetVariationSubset(int variationSubSet)
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
		public void SetWorldController(WorldSimController controller)
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x2B89DE0", Offset = "0x2B883E0", VA = "0x182B89DE0")]
		public bool IsInLifetime(float timeInHours)
		{
			return default(bool);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2B89E00", Offset = "0x2B88400", VA = "0x182B89E00")]
		public bool IsMoveInProgress()
		{
			return default(bool);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2B89E10", Offset = "0x2B88410", VA = "0x182B89E10")]
		private void TickMove(VailWorldSimulation worldSim, float deltaTime)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x2B89F40", Offset = "0x2B88540", VA = "0x182B89F40")]
		public void Tick(VailWorldSimulation worldSim, float deltaTime)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x2B8A2C0", Offset = "0x2B888C0", VA = "0x182B8A2C0")]
		public void ClearAction()
		{
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x2B8A320", Offset = "0x2B88920", VA = "0x182B8A320")]
		public void SetDestination(Vector3 targetPos)
		{
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x2B8A480", Offset = "0x2B88A80", VA = "0x182B8A480")]
		public void OnStartAction(WorldSimAction action, float timeInHours)
		{
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2B8A4E0", Offset = "0x2B88AE0", VA = "0x182B8A4E0")]
		public bool IsActionRunning(VailWorldSimulation worldSim)
		{
			return default(bool);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2B8A530", Offset = "0x2B88B30", VA = "0x182B8A530")]
		public Vector3 OnConvertSpawnPosition(VailActor vailActor, bool avoidBases)
		{
			return default(Vector3);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2B8A930", Offset = "0x2B88F30", VA = "0x182B8A930")]
		public void ConvertToVailActor(VailActor vailActor)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x2B8AC00", Offset = "0x2B89200", VA = "0x182B8AC00")]
		public void ConvertFromVailActor(VailActor actor)
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2B8B1D0", Offset = "0x2B897D0", VA = "0x182B8B1D0")]
		public void SetStateFlags(WorldSimActor.StateFlags newFlags)
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x2B8B1E0", Offset = "0x2B897E0", VA = "0x182B8B1E0")]
		public bool HasStateFlag(WorldSimActor.StateFlags testFlag)
		{
			return default(bool);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x2B8B1F0", Offset = "0x2B897F0", VA = "0x182B8B1F0")]
		public void AddSentiment(MonoBehaviourStimuli stimuli, float sentimentAdjust, bool removeFear = false)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x2B8B390", Offset = "0x2B89990", VA = "0x182B8B390")]
		public float GetSentimentFactor(Type stimuliType)
		{
			return 0f;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x2B8B480", Offset = "0x2B89A80", VA = "0x182B8B480")]
		public static int GetSentimentLevel(float sentimentFactor)
		{
			return 0;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x2B8B4D0", Offset = "0x2B89AD0", VA = "0x182B8B4D0")]
		public int GetPlayerSentimentLevel()
		{
			return 0;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A22")]
		[Address(RVA = "0x2B8B610", Offset = "0x2B89C10", VA = "0x182B8B610")]
		public void SetEquipped(int itemId, int count)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000A23")]
		[Address(RVA = "0x2B8B730", Offset = "0x2B89D30", VA = "0x182B8B730")]
		public bool IsEquipped(int itemId)
		{
			return default(bool);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x2B8B7D0", Offset = "0x2B89DD0", VA = "0x182B8B7D0")]
		public int GetEquippedCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x2B8B870", Offset = "0x2B89E70", VA = "0x182B8B870")]
		public void ClearEquipped()
		{
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x781500", Offset = "0x77FB00", VA = "0x180781500")]
		public void SetOutfit(int id)
		{
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2B8B8C0", Offset = "0x2B89EC0", VA = "0x182B8B8C0")]
		public WorldSimActor.ActorData GetSaveData()
		{
			return null;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x2B8BEB0", Offset = "0x2B8A4B0", VA = "0x182B8BEB0")]
		public void LoadPreSpawn(WorldSimActor.ActorData data, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x2B8C330", Offset = "0x2B8A930", VA = "0x182B8C330")]
		public void LoadPostSpawn(WorldSimActor.ActorData data)
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x2B8C620", Offset = "0x2B8AC20", VA = "0x182B8C620")]
		public string GetThought()
		{
			return null;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnDrawDebug(Color color, Vector3 size, bool showActions)
		{
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x2B8C6A0", Offset = "0x2B8ACA0", VA = "0x182B8C6A0")]
		public WorldSimActor()
		{
		}

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		private const float UpdateStatsTickMin = 1.5f;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		private const float UpdateStatsTickMax = 2f;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		private const float ChooseActionTick = 1.5f;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x10")]
		private VailActorTypeId _typeId;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x14")]
		private int _uniqueId;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x18")]
		private int _actorSeed;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x1C")]
		private int _variationId;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x20")]
		private int _variationSubSet;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x24")]
		private int _outfitId;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x28")]
		private int _tickOffset;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x2C")]
		private float _statTickDelta;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _position;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion _rotation;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x4C")]
		private GraphMask _graphMask;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x50")]
		private bool _keepAboveTerrain;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x54")]
		private float _lifetimeEnd;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x68")]
		private State _state;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x88")]
		private bool _persistentStats;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x90")]
		private StatsManager _statsManager;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<int, int> _equippedItems;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0xA0")]
		private AreaMask _areaMask;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0xA4")]
		private bool _alwaysRelevant;

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0xA8")]
		private float _relevantDistance;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0xB0")]
		private IVailSpawner _spawnedBy;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0xB8")]
		private IActorZone _currentZone;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0xC0")]
		private float _speed;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0xC8")]
		private WorldSimController _worldSimController;

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0xD0")]
		private WorldSimAction _runningAction;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0xD8")]
		private float _actionStartTimeHours;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0xDC")]
		private float _actionChooseTime;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 _destination;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0xEC")]
		private WorldSimActor.MoveToDest _moveToDest;

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0xF0")]
		private float _stateStartTimeInHours;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0xF4")]
		private float _nextGiftTimeHours;

		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0xF8")]
		private float _lastVisitTimeHours;

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0xFC")]
		private WorldSimActor.StateFlags _stateFlags;

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		private const float LikesPlayerThreshold2 = 0.4f;

		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		private const float LikesPlayerThreshold1 = 0.15f;

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		private enum MoveToDest
		{
			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			None,
			// Token: 0x040007FE RID: 2046
			[Token(Token = "0x40007FE")]
			Moving,
			// Token: 0x040007FF RID: 2047
			[Token(Token = "0x40007FF")]
			AtDestination
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		[Flags]
		public enum StateFlags
		{
			// Token: 0x04000801 RID: 2049
			[Token(Token = "0x4000801")]
			Skinned = 1
		}

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		[Serializable]
		public class ActorData
		{
			// Token: 0x06000A2D RID: 2605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ActorData()
			{
			}

			// Token: 0x04000802 RID: 2050
			[Token(Token = "0x4000802")]
			[FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x04000803 RID: 2051
			[Token(Token = "0x4000803")]
			[FieldOffset(Offset = "0x14")]
			public uint TypeId;

			// Token: 0x04000804 RID: 2052
			[Token(Token = "0x4000804")]
			[FieldOffset(Offset = "0x18")]
			public int FamilyId;

			// Token: 0x04000805 RID: 2053
			[Token(Token = "0x4000805")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3S Position;

			// Token: 0x04000806 RID: 2054
			[Token(Token = "0x4000806")]
			[FieldOffset(Offset = "0x28")]
			public Vector4S Rotation;

			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			[FieldOffset(Offset = "0x38")]
			public int SpawnerId;

			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			[FieldOffset(Offset = "0x3C")]
			public int ActorSeed;

			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x40")]
			public int VariationId;

			// Token: 0x0400080A RID: 2058
			[Token(Token = "0x400080A")]
			[FieldOffset(Offset = "0x44")]
			public int State;

			// Token: 0x0400080B RID: 2059
			[Token(Token = "0x400080B")]
			[FieldOffset(Offset = "0x48")]
			public int GraphMask;

			// Token: 0x0400080C RID: 2060
			[Token(Token = "0x400080C")]
			[FieldOffset(Offset = "0x50")]
			public List<int> EquippedItems;

			// Token: 0x0400080D RID: 2061
			[Token(Token = "0x400080D")]
			[FieldOffset(Offset = "0x58")]
			public int OutfitId;

			// Token: 0x0400080E RID: 2062
			[Token(Token = "0x400080E")]
			[FieldOffset(Offset = "0x5C")]
			public float NextGiftTime;

			// Token: 0x0400080F RID: 2063
			[Token(Token = "0x400080F")]
			[FieldOffset(Offset = "0x60")]
			public float LastVisitTime;

			// Token: 0x04000810 RID: 2064
			[Token(Token = "0x4000810")]
			[FieldOffset(Offset = "0x68")]
			public WorldSimActor.ActorStatsData Stats;

			// Token: 0x04000811 RID: 2065
			[Token(Token = "0x4000811")]
			[FieldOffset(Offset = "0x70")]
			public int StateFlags;
		}

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		public class ActorStatsData
		{
			// Token: 0x06000A2E RID: 2606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ActorStatsData()
			{
			}

			// Token: 0x04000812 RID: 2066
			[Token(Token = "0x4000812")]
			[FieldOffset(Offset = "0x10")]
			public float Health;

			// Token: 0x04000813 RID: 2067
			[Token(Token = "0x4000813")]
			[FieldOffset(Offset = "0x14")]
			public float Anger;

			// Token: 0x04000814 RID: 2068
			[Token(Token = "0x4000814")]
			[FieldOffset(Offset = "0x18")]
			public float Fear;

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x1C")]
			public float Fullness;

			// Token: 0x04000816 RID: 2070
			[Token(Token = "0x4000816")]
			[FieldOffset(Offset = "0x20")]
			public float Hydration;

			// Token: 0x04000817 RID: 2071
			[Token(Token = "0x4000817")]
			[FieldOffset(Offset = "0x24")]
			public float Energy;

			// Token: 0x04000818 RID: 2072
			[Token(Token = "0x4000818")]
			[FieldOffset(Offset = "0x28")]
			public float Affection;
		}
	}
}
