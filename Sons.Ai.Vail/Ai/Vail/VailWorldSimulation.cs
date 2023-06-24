using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bolt;
using Endnight.Utilities;
using Il2CppDummyDll;
using Pathfinding;
using Sons.Ai.Vail.Memory;
using Sons.Ai.Vail.StimuliTypes;
using Sons.Areas;
using Sons.Atmosphere;
using Sons.Environment;
using Sons.Save;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[AddComponentMenu("Sons/Ai/Vail World Simulation")]
	[DefaultExecutionOrder(-2)]
	public class VailWorldSimulation : EntityEventListener<IVailWorldState>, ISeasonsReceiver, IEnvironmentWetnessReceiver, ISaveGameSerializer<VailWorldSimulation.VailSaveData>
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000083")]
		public VailWorldPaths WorldPaths
		{
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000084")]
		public FindNavPath NavPathFinder
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000085")]
		public static IConstructionVailActions ConstructionActions
		{
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x2B6F980", Offset = "0x2B6DF80", VA = "0x182B6F980")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
		public List<VailZoneBase> GetVailZones()
		{
			return null;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2B6F9D0", Offset = "0x2B6DFD0", VA = "0x182B6F9D0")]
		public static void SetPaused(bool value)
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2B6FAE0", Offset = "0x2B6E0E0", VA = "0x182B6FAE0")]
		public static void SetDisabled(bool value)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x2B6FBA0", Offset = "0x2B6E1A0", VA = "0x182B6FBA0")]
		public static void SetAnimalsEnabled(bool value)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x17000086")]
		public bool IsDisabled
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x2875120", Offset = "0x2873720", VA = "0x182875120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x17000087")]
		public bool IsPaused
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00005F10 File Offset: 0x00004110
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public int DaysPassed
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xAFF4C0", Offset = "0xAFDAC0", VA = "0x180AFF4C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xAFF4D0", Offset = "0xAFDAD0", VA = "0x180AFF4D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public float TimeInHours
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1342A00", Offset = "0x1341000", VA = "0x181342A00")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1342A10", Offset = "0x1341010", VA = "0x181342A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00005F40 File Offset: 0x00004140
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008A")]
		public float HourOfDay
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1342A20", Offset = "0x1341020", VA = "0x181342A20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1342A30", Offset = "0x1341030", VA = "0x181342A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00005F58 File Offset: 0x00004158
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public float DarknessFactor
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1342C20", Offset = "0x1341220", VA = "0x181342C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x00005F70 File Offset: 0x00004170
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public SeasonsManager.Season CurrentSeason
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540")]
			[CompilerGenerated]
			get
			{
				return SeasonsManager.Season.Spring;
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xAFF550", Offset = "0xAFDB50", VA = "0x180AFF550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00005F88 File Offset: 0x00004188
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		public float CurrentWetness
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40")]
		public void SetCurrentWetness(float wetness)
		{
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x1700008E")]
		public int ActorCount
		{
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x2B6FC50", Offset = "0x2B6E250", VA = "0x182B6FC50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x2B6FC90", Offset = "0x2B6E290", VA = "0x182B6FC90")]
		public static int GetActorUniqueId()
		{
			return 0;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x2B6FCF0", Offset = "0x2B6E2F0", VA = "0x182B6FCF0")]
		public static int GetTickOffset()
		{
			return 0;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
		public void RegisterWorldEventSystem(IWorldEventsSystem worldEventSystem)
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
		public void RegisterWorldQuerySystem(IWorldQuerySystem worldQuerySystem)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x1700008F")]
		public bool ShouldSpawnEnemies
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x2B6FD70", Offset = "0x2B6E370", VA = "0x182B6FD70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x2B6FD80", Offset = "0x2B6E380", VA = "0x182B6FD80")]
		private void CacheGameSettings()
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x2B6FE20", Offset = "0x2B6E420", VA = "0x182B6FE20")]
		public static VailWorldSimulation Instance()
		{
			return null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x2B6FF60", Offset = "0x2B6E560", VA = "0x182B6FF60")]
		public static bool TryGetInstance(out VailWorldSimulation instance)
		{
			return default(bool);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x2B70130", Offset = "0x2B6E730", VA = "0x182B70130")]
		private void OnValidate()
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x2B70660", Offset = "0x2B6EC60", VA = "0x182B70660")]
		private void Initialize()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x2B70990", Offset = "0x2B6EF90", VA = "0x182B70990")]
		private void Awake()
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x2B70B00", Offset = "0x2B6F100", VA = "0x182B70B00")]
		private void OnEnable()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x2B70BC0", Offset = "0x2B6F1C0", VA = "0x182B70BC0")]
		private void OnDisable()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x2B70C80", Offset = "0x2B6F280", VA = "0x182B70C80")]
		private void Start()
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x2B70D50", Offset = "0x2B6F350", VA = "0x182B70D50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x2B70E00", Offset = "0x2B6F400", VA = "0x182B70E00")]
		public static void OnClientDisconnected()
		{
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x2B70EE0", Offset = "0x2B6F4E0", VA = "0x182B70EE0")]
		public WorldSimActor SpawnActor(VailActor prefab, Vector3 position, GraphMask graphMask, IVailSpawner spawnedBy, State spawnState, int family = 0, int variationId = -1, bool instantSpawn = false, bool skipConvertCheck = false)
		{
			return null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2B711F0", Offset = "0x2B6F7F0", VA = "0x182B711F0")]
		public void AddActor(WorldSimActor actor, bool onLoad = false)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2B713D0", Offset = "0x2B6F9D0", VA = "0x182B713D0")]
		private void RemoveActorAtIndex(int index)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2B715E0", Offset = "0x2B6FBE0", VA = "0x182B715E0")]
		public void RemoveActor(WorldSimActor removeActor)
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x2B71690", Offset = "0x2B6FC90", VA = "0x182B71690")]
		public void RemoveActorsFromSpawner(IVailSpawner spawner, bool removeActive)
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x2B718F0", Offset = "0x2B6FEF0", VA = "0x182B718F0")]
		public void Register(ISimpleSpawner spawner)
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2B719F0", Offset = "0x2B6FFF0", VA = "0x182B719F0")]
		public void Register(IVailSpawner spawner)
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2B71AF0", Offset = "0x2B700F0", VA = "0x182B71AF0")]
		public void Register(VailZoneBase zone)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x2B71BE0", Offset = "0x2B701E0", VA = "0x182B71BE0")]
		public static void RegisterConstructionActions(IConstructionVailActions constructionActions)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x2B71C90", Offset = "0x2B70290", VA = "0x182B71C90")]
		public static WorldSimActor Register(VailActor vailActor)
		{
			return null;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x2B71CF0", Offset = "0x2B702F0", VA = "0x182B71CF0")]
		private WorldSimActor RegisterInternal(VailActor vailActor)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x2B71F40", Offset = "0x2B70540", VA = "0x182B71F40")]
		public WorldSimActor[] GetAllActors()
		{
			return null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x2B71F90", Offset = "0x2B70590", VA = "0x182B71F90")]
		public CharacterMaterials.MaterialsForType GetCharacterMaterials(VailActorTypeId typeId)
		{
			return null;
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		public PlayerEffigyStimuli GetGetPlayerEffigyStimuli()
		{
			return null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x2B71FC0", Offset = "0x2B705C0", VA = "0x182B71FC0")]
		public static void SetRobbySpawnLocation(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x2B72130", Offset = "0x2B70730", VA = "0x182B72130")]
		private void TrySpawnRobby()
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x2B721F0", Offset = "0x2B707F0", VA = "0x182B721F0")]
		public static VailActor ServerSpawnVailActor(VailActor prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2B72510", Offset = "0x2B70B10", VA = "0x182B72510")]
		public VailActor ConvertToRealActor(WorldSimActor actor, [Optional] VailActor forcePrefab)
		{
			return null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2B72D80", Offset = "0x2B71380", VA = "0x182B72D80")]
		public void ConvertToWorldSimActor(VailActor vailActor)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2B73220", Offset = "0x2B71820", VA = "0x182B73220")]
		private void ClearPerfTimers()
		{
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2B73280", Offset = "0x2B71880", VA = "0x182B73280")]
		private void Update()
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2B734E0", Offset = "0x2B71AE0", VA = "0x182B734E0")]
		private void UpdateServer(List<PlayerLocation.ViewerInfo> localViewer)
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2B739F0", Offset = "0x2B71FF0", VA = "0x182B739F0")]
		private void UpdateClient(List<PlayerLocation.ViewerInfo> localViewer)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2B73C10", Offset = "0x2B72210", VA = "0x182B73C10")]
		private void TickSimpleAnimals()
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x2B73F90", Offset = "0x2B72590", VA = "0x182B73F90")]
		private void DisableSimpleAnimals()
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x2B74170", Offset = "0x2B72770", VA = "0x182B74170")]
		private void TickSpawners(float deltaTime)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x2B74360", Offset = "0x2B72960", VA = "0x182B74360")]
		private void UpdateRelevantSpawnZones(List<PlayerLocation.ViewerInfo> viewPositions)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x2B745B0", Offset = "0x2B72BB0", VA = "0x182B745B0")]
		private void UpdateSimpleActorZones(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x2B747A0", Offset = "0x2B72DA0", VA = "0x182B747A0")]
		private bool RecentlyTeleported()
		{
			return default(bool);
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x2B74810", Offset = "0x2B72E10", VA = "0x182B74810")]
		private bool TeleportedThisFrame()
		{
			return default(bool);
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x2B74880", Offset = "0x2B72E80", VA = "0x182B74880")]
		private void TickSimulation()
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x2B74FE0", Offset = "0x2B735E0", VA = "0x182B74FE0")]
		private void TickVillagesAndCaves(bool isServer)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x2B75140", Offset = "0x2B73740", VA = "0x182B75140")]
		public static AreaMask GetViewerAreaMask(int areaMask)
		{
			return AreaMask.None;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x2B75150", Offset = "0x2B73750", VA = "0x182B75150")]
		private static void GetViewCheckDistances(VailActorTypeId typeId, out float alwaysTrueDist, out float maxViewCheckDist)
		{
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x2B751B0", Offset = "0x2B737B0", VA = "0x182B751B0")]
		private void UpdateRelevantActors(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x2B759B0", Offset = "0x2B73FB0", VA = "0x182B759B0")]
		private bool SpawnOnGround(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2B75A70", Offset = "0x2B74070", VA = "0x182B75A70")]
		private bool IsOverValidGround(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2B75E10", Offset = "0x2B74410", VA = "0x182B75E10")]
		public void DeactivateActors(List<VailActor> actorsToDeactivate)
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetNetworkStateObject(VailWorldStateNetworked networkState)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x2B75F70", Offset = "0x2B74570", VA = "0x182B75F70")]
		public MonoBehaviourStimuli GetStimuliInRange(WorldSimActor actor, Type stimuliType, float maxRange)
		{
			return null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x2B761A0", Offset = "0x2B747A0", VA = "0x182B761A0")]
		public int GetNavGraphMaskForArea(AreaMask areaMask)
		{
			return 0;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x2B76340", Offset = "0x2B74940", VA = "0x182B76340")]
		public AreaMask GetAreaMaskFromNavMask(int navGraphMask)
		{
			return AreaMask.None;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x2B764E0", Offset = "0x2B74AE0", VA = "0x182B764E0")]
		public void OnActorDied(WorldSimActor deadActor, bool killedByPlayer)
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x2B76670", Offset = "0x2B74C70", VA = "0x182B76670")]
		private static void CheckForUniqueActorDeaths(WorldSimActor deadActor, bool killedByPlayer)
		{
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x2B76940", Offset = "0x2B74F40", VA = "0x182B76940")]
		public float GetVirginiaSentimentFactor(Type stimuliType)
		{
			return 0f;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x2B76AD0", Offset = "0x2B750D0", VA = "0x182B76AD0")]
		public void AddVirginiaSentiment(MonoBehaviourStimuli stimuli, float sentimentAdjust)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x2B76C50", Offset = "0x2B75250", VA = "0x182B76C50")]
		public int KillInRadius(Vector3 position, float radius, VailActorClassId classId = VailActorClassId.None, int maxKilled = 2147483647)
		{
			return 0;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x2B76E60", Offset = "0x2B75460", VA = "0x182B76E60")]
		public int CreepyKillAnimalInRadius(Vector3 position, float radius, int maxKilled)
		{
			return 0;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x2B77080", Offset = "0x2B75680", VA = "0x182B77080")]
		public int KillFromSpawner(IVailSpawner spawner)
		{
			return 0;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x2B77280", Offset = "0x2B75880", VA = "0x182B77280", Slot = "322")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x2B6FC40", Offset = "0x2B6E240", VA = "0x182B6FC40", Slot = "324")]
		public void UpdateWetness(float wetness)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x2B772A0", Offset = "0x2B758A0", VA = "0x182B772A0")]
		public bool IsWithinHourRange(Vector2Int hourOfDayRange)
		{
			return default(bool);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x2B77370", Offset = "0x2B75970", VA = "0x182B77370")]
		private static bool IsWithinHourRange(float hourOfDay, Vector2Int hourOfDayRange)
		{
			return default(bool);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x2B773C0", Offset = "0x2B759C0", VA = "0x182B773C0")]
		public bool IsPointInVillage(Vector3 point, float marginDist = 2f, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x2B775A0", Offset = "0x2B75BA0", VA = "0x182B775A0")]
		public VailZoneBase GetClosestZone(Vector3 position, VailZoneId zoneType)
		{
			return null;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x2B777D0", Offset = "0x2B75DD0", VA = "0x182B777D0")]
		public void GetClosestZones(List<VailZoneBase> zones, Vector3 position, VailZoneId zoneType)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x2B77B20", Offset = "0x2B76120", VA = "0x182B77B20")]
		public void SetCaveOpen(int areaMask, bool isOpen)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x2B77B60", Offset = "0x2B76160", VA = "0x182B77B60")]
		public bool IsCaveOpen(int areaMask)
		{
			return default(bool);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x2B77B80", Offset = "0x2B76180", VA = "0x182B77B80")]
		public bool IsAnyCaveOpen()
		{
			return default(bool);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x2B77BA0", Offset = "0x2B761A0", VA = "0x182B77BA0")]
		public void SetWorldStateFlag(VailWorldStateNetworked.WorldFlags flag)
		{
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x2B77CA0", Offset = "0x2B762A0", VA = "0x182B77CA0")]
		public bool HasWorldFlag(VailWorldStateNetworked.WorldFlags flag)
		{
			return default(bool);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x2B77CC0", Offset = "0x2B762C0", VA = "0x182B77CC0")]
		public WorldSimActor GetActorTypeInArea(VailActorTypeId typeId, AreaMask areaMask)
		{
			return null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x2B77E30", Offset = "0x2B76430", VA = "0x182B77E30")]
		public bool IsNearBush(Vector3 point, float radius, out Vector3 bushPos)
		{
			return default(bool);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x2B77F30", Offset = "0x2B76530", VA = "0x182B77F30")]
		public bool IsNearTree(Vector3 point, float radius, out Vector3 closestTreePos)
		{
			return default(bool);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x2B78030", Offset = "0x2B76630", VA = "0x182B78030")]
		public int TreesInRadius(Vector3 point, float radius)
		{
			return 0;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x2B78120", Offset = "0x2B76720", VA = "0x182B78120")]
		public void CameraShakeEvent(Vector3 pos, float radius)
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x2B781A0", Offset = "0x2B767A0", VA = "0x182B781A0")]
		public void OnHelicopterPickup()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x2B781F0", Offset = "0x2B767F0", VA = "0x182B781F0")]
		public bool HasPlayerSightings()
		{
			return default(bool);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x2B78240", Offset = "0x2B76840", VA = "0x182B78240")]
		private VailWorldSimulation.PlayerSighting GetMostRecentSighting()
		{
			return default(VailWorldSimulation.PlayerSighting);
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x2B784B0", Offset = "0x2B76AB0", VA = "0x182B784B0")]
		public Vector3 GetRandomPlayerSightedPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x2B785B0", Offset = "0x2B76BB0", VA = "0x182B785B0")]
		public void OnPlayerSighted(WorldSimActor actor, Vector3 position)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x2B78A40", Offset = "0x2B77040", VA = "0x182B78A40")]
		public static float GetCannibalAngerLevel(int days, float cannibalsKilled, int seenInVillage, int treesCut)
		{
			return 0f;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x2B78AB0", Offset = "0x2B770B0", VA = "0x182B78AB0")]
		public float GetCannibalAngerLevel()
		{
			return 0f;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x2B78C20", Offset = "0x2B77220", VA = "0x182B78C20")]
		public static float GetCannibalArmorLevel(int day, float cannibalsKilled)
		{
			return 0f;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x2B78C80", Offset = "0x2B77280", VA = "0x182B78C80")]
		private float GetCannibalArmorLevel()
		{
			return 0f;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x2B78ED0", Offset = "0x2B774D0", VA = "0x182B78ED0")]
		public float GetArmorLevelForActor(WorldSimActor actor)
		{
			return 0f;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x2B78FD0", Offset = "0x2B775D0", VA = "0x182B78FD0")]
		public VailActor FindActor(VailActorTypeId actorTypeId)
		{
			return null;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x2B79060", Offset = "0x2B77660", VA = "0x182B79060")]
		public WorldSimActor FindWorldActor(VailActorTypeId actorTypeId)
		{
			return null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x2B791B0", Offset = "0x2B777B0", VA = "0x182B791B0")]
		public WorldSimActor FindWorldActor(int uniqueId)
		{
			return null;
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091F")]
		[Address(RVA = "0x2B79300", Offset = "0x2B77900", VA = "0x182B79300")]
		public void SetActorGpsLocator(WorldSimActor actor, bool active, int iconId = -1)
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x2B79420", Offset = "0x2B77A20", VA = "0x182B79420")]
		public int GetGpsLocatorTypeId(WorldSimActor actor)
		{
			return 0;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x2B794F0", Offset = "0x2B77AF0", VA = "0x182B794F0")]
		public void OnVailZoneStateNetworkEvent(VailZoneStateEvent evt)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x2B79780", Offset = "0x2B77D80", VA = "0x182B79780")]
		private void StunShrineEvent()
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x2B79890", Offset = "0x2B77E90", VA = "0x182B79890")]
		public static void ShowWorldStats(bool value)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x2B79920", Offset = "0x2B77F20", VA = "0x182B79920")]
		public static void SetZoneStats(bool value)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x2B799B0", Offset = "0x2B77FB0", VA = "0x182B799B0")]
		public static void SetDebugClosestVillage(bool value)
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x2B79A40", Offset = "0x2B78040", VA = "0x182B79A40")]
		public static void ShowActorPoolStats(bool value)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x000062D0 File Offset: 0x000044D0
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		public static bool WorldStats
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x2B79AD0", Offset = "0x2B780D0", VA = "0x182B79AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x2B79B20", Offset = "0x2B78120", VA = "0x182B79B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x000062E8 File Offset: 0x000044E8
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public static bool ZoneStats
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x2B79B80", Offset = "0x2B78180", VA = "0x182B79B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x2B79BD0", Offset = "0x2B781D0", VA = "0x182B79BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00006300 File Offset: 0x00004500
		// (set) Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public static bool ActorPoolStats
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x2B79C30", Offset = "0x2B78230", VA = "0x182B79C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x2B79C80", Offset = "0x2B78280", VA = "0x182B79C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00006318 File Offset: 0x00004518
		// (set) Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		private static bool DebugClosestVillage
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x2B79CE0", Offset = "0x2B782E0", VA = "0x182B79CE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x2B79D30", Offset = "0x2B78330", VA = "0x182B79D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00006330 File Offset: 0x00004530
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		public static int DebugArmorTier
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x2B79D90", Offset = "0x2B78390", VA = "0x182B79D90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x2B79DE0", Offset = "0x2B783E0", VA = "0x182B79DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000931")]
		[Address(RVA = "0x2B79E40", Offset = "0x2B78440", VA = "0x182B79E40")]
		public void GetTypesForController(VailController controller, ref List<VailActorTypeId> types)
		{
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000932")]
		[Address(RVA = "0x2B79EC0", Offset = "0x2B784C0", VA = "0x182B79EC0")]
		public static void MarkUnwalkableNodes()
		{
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000933")]
		[Address(RVA = "0x2B79F10", Offset = "0x2B78510", VA = "0x182B79F10")]
		public static void TagIsolatedNodes()
		{
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x2B79F60", Offset = "0x2B78560", VA = "0x182B79F60")]
		public static void RecalculateNavGraph()
		{
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6000935")]
		[Address(RVA = "0x2B79FA0", Offset = "0x2B785A0", VA = "0x182B79FA0")]
		public float GetWorldTickMs()
		{
			return 0f;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x2B79FD0", Offset = "0x2B785D0", VA = "0x182B79FD0")]
		public float GetSimpleTickMs()
		{
			return 0f;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x2B7A000", Offset = "0x2B78600", VA = "0x182B7A000")]
		public static void DebugForceArmorLevel(float forceArmorLevel)
		{
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x2B7A0A0", Offset = "0x2B786A0", VA = "0x182B7A0A0")]
		public static void DebugForceArmorTier(int tier)
		{
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x2B7A130", Offset = "0x2B78730", VA = "0x182B7A130")]
		public static void DebugForceAngerLevel(float forceAngerLevel)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x2B7A1D0", Offset = "0x2B787D0", VA = "0x182B7A1D0")]
		private string GetActorTypeString(VailActorClassId classId, out int actorCount, out int activeActorCount, out int familyCount)
		{
			return null;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093B")]
		private static void GetStats<T>(List<T> spawnZones, out int activeZoneCount, out int activeActorCount, out int totalActorCount) where T : ISpawner
		{
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x2B7A750", Offset = "0x2B78D50", VA = "0x182B7A750")]
		public static bool ShouldShowGui()
		{
			return default(bool);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x2B7A860", Offset = "0x2B78E60", VA = "0x182B7A860")]
		public static void OnDrawDebug()
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x2B7AD60", Offset = "0x2B79360", VA = "0x182B7AD60")]
		public static void OnDebugRadarGUI(VailRadarType radarType, string filter)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x2B7AE70", Offset = "0x2B79470", VA = "0x182B7AE70")]
		private void OnWorldStatsGUI()
		{
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x2B7C5F0", Offset = "0x2B7ABF0", VA = "0x182B7C5F0")]
		private void OnZoneStatsGUI()
		{
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x2B7D070", Offset = "0x2B7B670", VA = "0x182B7D070")]
		private void OnDebugClosestVillage()
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x2B7D1B0", Offset = "0x2B7B7B0", VA = "0x182B7D1B0")]
		public void OnDebugRadarInternal(VailRadarType radarType, string filter, VailZoneBase zoneFilter, bool thoughts = false)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x2B7E110", Offset = "0x2B7C710", VA = "0x182B7E110")]
		public void OnDrawGizmos()
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x2B7E600", Offset = "0x2B7CC00", VA = "0x182B7E600")]
		public static int NewFamily()
		{
			return 0;
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x2B7E660", Offset = "0x2B7CC60", VA = "0x182B7E660")]
		private void AddActorToFamily(WorldSimActor actor)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x2B7E870", Offset = "0x2B7CE70", VA = "0x182B7E870")]
		private void RemoveActorFromFamily(WorldSimActor actor)
		{
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x2B7E900", Offset = "0x2B7CF00", VA = "0x182B7E900")]
		private bool TryGetFamily(int familyId, out VailWorldSimulation.Family family)
		{
			return default(bool);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x2B7E9D0", Offset = "0x2B7CFD0", VA = "0x182B7E9D0")]
		public int FamilyCount(int familyId)
		{
			return 0;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x2B7EBE0", Offset = "0x2B7D1E0", VA = "0x182B7EBE0")]
		public int GetFamilyActiveCount(int familyId)
		{
			return 0;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x2B7ED90", Offset = "0x2B7D390", VA = "0x182B7ED90")]
		public void SetFamilyLifetimeEnd(int familyId, float lifetimeEndInHours)
		{
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x2B7EF20", Offset = "0x2B7D520", VA = "0x182B7EF20")]
		public void DoFamilyMove(int familyId, Vector3 destPosition, float destRadius, State moveState)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x2B7F200", Offset = "0x2B7D800", VA = "0x182B7F200")]
		public bool IsFamilyMoveInProgress(int familyId)
		{
			return default(bool);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x17000095")]
		private string SerializedName
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x2B7F3A0", Offset = "0x2B7D9A0", VA = "0x182B7F3A0", Slot = "325")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x17000096")]
		private bool UniqueFile
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "328")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x17000097")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "329")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x17000098")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x2B7F3D0", Offset = "0x2B7D9D0", VA = "0x182B7F3D0")]
		public ISpawner GetSpawner(int spawnerId)
		{
			return null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x2B7F450", Offset = "0x2B7DA50", VA = "0x182B7F450")]
		public VailZoneBase GetVailZone(int zoneId)
		{
			return null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x2B7F4D0", Offset = "0x2B7DAD0", VA = "0x182B7F4D0")]
		public static void ValidateUniqueId(ref int uniqueId, Component component)
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x2B7F760", Offset = "0x2B7DD60", VA = "0x182B7F760", Slot = "326")]
		private VailWorldSimulation.VailSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000955")]
		private void SaveSpawnZones<T>(List<T> spawnZones, VailWorldSimulation.VailSaveData saveData) where T : ISpawner
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x2B80420", Offset = "0x2B7EA20", VA = "0x182B80420")]
		public static void LogInvalidIds(List<int> invalidIds, string typeName)
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x2B807B0", Offset = "0x2B7EDB0", VA = "0x182B807B0")]
		private void OnBeforeLoad()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x2B80B90", Offset = "0x2B7F190", VA = "0x182B80B90")]
		private void DeserializeSaveData(VailWorldSimulation.VailSaveData saveData)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x2B81F50", Offset = "0x2B80550", VA = "0x182B81F50")]
		private void OnAfterLoad()
		{
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x2B82030", Offset = "0x2B80630", VA = "0x182B82030", Slot = "327")]
		private void OnDeserialize(VailWorldSimulation.VailSaveData saveData)
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x2B82040", Offset = "0x2B80640", VA = "0x182B82040")]
		public void RemoveExtraActors(int maxCount, GraphMask navGraphMask, VailZoneBase zone)
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x2B824C0", Offset = "0x2B80AC0", VA = "0x182B824C0")]
		private void RespawnActorPosition(WorldSimActor actor, Dictionary<int, Vector3> familySpawnPositions)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x2B82690", Offset = "0x2B80C90", VA = "0x182B82690")]
		public void OnPlayerSleep(Vector3 playerPos, float sleepHours)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x2B82F60", Offset = "0x2B81560", VA = "0x182B82F60")]
		private bool IsValidSleepCheckState(State actorState)
		{
			return default(bool);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x2B83080", Offset = "0x2B81680", VA = "0x182B83080")]
		public int SleepCheckEnemies(Vector3 position, float radius, int navGraphMask, out WorldSimActor nearActor)
		{
			return 0;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x2B83510", Offset = "0x2B81B10", VA = "0x182B83510")]
		public void OnPlayerCutTree(Vector3 position)
		{
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x2B83530", Offset = "0x2B81B30", VA = "0x182B83530")]
		private VailWorldSimulation.ActorTypeInfo GetTypeInfo(VailActorTypeId key)
		{
			return null;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x2B83630", Offset = "0x2B81C30", VA = "0x182B83630")]
		public void StatsOnSpawn(VailActorTypeId typeId, int change = 1)
		{
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x2B83660", Offset = "0x2B81C60", VA = "0x182B83660")]
		public void StatsOnDespawn(VailActorTypeId typeId)
		{
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x2B83680", Offset = "0x2B81C80", VA = "0x182B83680")]
		public void StatsOnDied(VailActorTypeId typeId, bool killedByPlayer)
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x2B836B0", Offset = "0x2B81CB0", VA = "0x182B836B0")]
		private float GetCannibalsKilledByPlayerCount()
		{
			return 0f;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x2B83910", Offset = "0x2B81F10", VA = "0x182B83910")]
		private float GetKilledByPlayerCount(VailActorClassId classId)
		{
			return 0f;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x2B83B40", Offset = "0x2B82140", VA = "0x182B83B40")]
		public VailWorldSimulation()
		{
		}

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		private const float UpdateRelevantActorsTick = 0.15f;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		private const float UpdateRelevantZonesTick = 0.3f;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		private const float UpdateSpawnerTick = 0.35f;

		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		private const float NetworkRelevantActorsTick = 0.5f;

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		private const float MaxRelevantActorDistance = 140f;

		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		private const float MaxDeadActorDistanceSqr = 90000f;

		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		private const float MaxDeadHours = 18f;

		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		private const float TeleportDistSqr = 100f;

		// Token: 0x0400072E RID: 1838
		[Token(Token = "0x400072E")]
		private const int NumWorldActorTickOffsets = 14;

		// Token: 0x0400072F RID: 1839
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailActorPools _actorPools;

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailWorldPaths _worldPaths;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VailNavGraphModifier _navGraphModifier;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FindNavPath _navPathFinder;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VailWorldStateNetworked _worldStateNetworked;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _actorLocatorsObject;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VailActor _robbyPrefab;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private PlayerEffigyStimuli _playerEffigyStimuli;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly List<WorldSimActor> _actors;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<ISimpleSpawner> _simpleSpawners;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly List<IVailSpawner> _vailSpawners;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<VailZoneBase> _vailZoneBases;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private IWorldEventsSystem _worldEventSystem;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private IWorldQuerySystem _worldQuerySystem;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private IWorldActorLocators _worldActorLocators;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IConstructionVailActions _constructionActions;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool _aiPaused;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<WorldSimActor> _nearbyActors;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly List<WorldSimActor> _removeActorList;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Type> _typeList;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 _lastViewPos;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _lastTeleportTime;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool _instantActorSpawn;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool _animalsEnabled;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _lastUpdateRelevantActorTime;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _lastUpdateRelevantZoneTime;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float _lastTickSpawnerTime;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _lastNetworkRelevantTime;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private VailLevelGrid _actorGrid;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private VailActorManager _actorManager;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VailWorldSimulation _instance;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int _currentUniqueId;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static int _currentTickOffset;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int _offsetToTick;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly float[] _previousTickTime;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly PerfStats _perf;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly PerfStats _simplePerf;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool _robbySpawnActive;

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static Vector3 _robbySpawnPosition;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Quaternion _robbySpawnRotation;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool _disconnected;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		private bool _zoneListChanged;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		private bool _shouldSpawnEnemies;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly List<Type> StunShrineStimuliList;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x133")]
		[SerializeField]
		private bool _showActorPositions;

		// Token: 0x04000762 RID: 1890
		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private bool _showActorActions;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private VailActorClassId _showActorClassFilter;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private VailActorTypeId _showActorTypeFilter;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _showActorsOutsideOnly;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		[SerializeField]
		private bool _showPlayerSightings;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		[SerializeField]
		private bool _debugLog;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float _drawSize;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _aiDisabled;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static bool _debugForceArmor;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static float _debugForceArmorLevel;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static bool _debugForceAnger;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static float _debugForceAngerLevel;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private readonly Dictionary<int, VailWorldSimulation.Family> _families;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static int _currentFamilyId;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private VailWorldSimulation.VailSaveData _vailWorldSaveData;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<int, ISpawner> _findSpawnerById;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Dictionary<int, VailZoneBase> _findZoneById;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Dictionary<VailActorTypeId, VailWorldSimulation.ActorTypeInfo> _typeInfo;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private readonly List<VailWorldSimulation.PlayerSighting> _playerSightings;

		// Token: 0x0400077A RID: 1914
		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private VailWorldSimulation.PlayerWorldStats _playerWorldStats;

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000EA")]
		private class Family
		{
			// Token: 0x06000969 RID: 2409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x2B84800", Offset = "0x2B82E00", VA = "0x182B84800")]
			public Family()
			{
			}

			// Token: 0x0400077B RID: 1915
			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VailActorClassId ClassId;

			// Token: 0x0400077C RID: 1916
			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<WorldSimActor> Members;
		}

		// Token: 0x020000EB RID: 235
		[Token(Token = "0x20000EB")]
		[Serializable]
		public class VailSaveData
		{
			// Token: 0x0600096A RID: 2410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x2B848B0", Offset = "0x2B82EB0", VA = "0x182B848B0")]
			public VailSaveData()
			{
			}

			// Token: 0x0400077D RID: 1917
			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x0400077E RID: 1918
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<WorldSimActor.ActorData> Actors;

			// Token: 0x0400077F RID: 1919
			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<VailWorldSimulation.VailSpawnerData> Spawners;

			// Token: 0x04000780 RID: 1920
			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<ActorMemoryManager.ActorEventSaveData> EventMemory;

			// Token: 0x04000781 RID: 1921
			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<ActorMemoryManager.ActorInfluenceSaveData> InfluenceMemory;

			// Token: 0x04000782 RID: 1922
			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<VailWorldSimulation.KillStats> KillStatsList;

			// Token: 0x04000783 RID: 1923
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public VailWorldSimulation.WorldEventsSaveData WorldEventData;

			// Token: 0x04000784 RID: 1924
			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public VailWorldSimulation.PlayerWorldStats PlayerStats;
		}

		// Token: 0x020000EC RID: 236
		[Token(Token = "0x20000EC")]
		[Serializable]
		public class ZoneData
		{
			// Token: 0x0600096B RID: 2411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ZoneData()
			{
			}

			// Token: 0x04000785 RID: 1925
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x04000786 RID: 1926
			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float LastSpawnTime;

			// Token: 0x04000787 RID: 1927
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int NumSpawned;
		}

		// Token: 0x020000ED RID: 237
		[Token(Token = "0x20000ED")]
		[Serializable]
		public class VailSpawnerData
		{
			// Token: 0x0600096C RID: 2412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VailSpawnerData()
			{
			}

			// Token: 0x04000788 RID: 1928
			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int UniqueId;

			// Token: 0x04000789 RID: 1929
			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int Count;

			// Token: 0x0400078A RID: 1930
			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int SpawnedCount;

			// Token: 0x0400078B RID: 1931
			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastSpawnTime;
		}

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x20000EE")]
		[Serializable]
		public class KillStats
		{
			// Token: 0x0600096D RID: 2413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public KillStats()
			{
			}

			// Token: 0x0400078C RID: 1932
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public VailActorTypeId TypeId;

			// Token: 0x0400078D RID: 1933
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PlayerKilled;
		}

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x20000EF")]
		[Serializable]
		public class WorldEventsSaveData
		{
			// Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x2B84E10", Offset = "0x2B83410", VA = "0x182B84E10")]
			public WorldEventsSaveData()
			{
			}

			// Token: 0x0400078E RID: 1934
			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int LastQueuedDay;

			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<VailWorldSimulation.WorldEventQueued> QueuedWorldEvents;

			// Token: 0x04000790 RID: 1936
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<VailWorldSimulation.WorldEventTypeStats> WorldEventTypeStats;
		}

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		[Serializable]
		public class WorldEventQueued
		{
			// Token: 0x0600096F RID: 2415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public WorldEventQueued()
			{
			}

			// Token: 0x04000791 RID: 1937
			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04000792 RID: 1938
			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StartTimeHours;

			// Token: 0x04000793 RID: 1939
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Day;
		}

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x20000F1")]
		[Serializable]
		public class WorldEventTypeStats
		{
			// Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public WorldEventTypeStats()
			{
			}

			// Token: 0x04000794 RID: 1940
			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			// Token: 0x04000795 RID: 1941
			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastRunDay;

			// Token: 0x04000796 RID: 1942
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int RunCount;
		}

		// Token: 0x020000F2 RID: 242
		[Token(Token = "0x20000F2")]
		private class ActorTypeInfo
		{
			// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ActorTypeInfo()
			{
			}

			// Token: 0x04000797 RID: 1943
			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int worldCount;

			// Token: 0x04000798 RID: 1944
			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int activeCount;

			// Token: 0x04000799 RID: 1945
			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int deadCount;

			// Token: 0x0400079A RID: 1946
			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int playerKilledCount;
		}

		// Token: 0x020000F3 RID: 243
		[Token(Token = "0x20000F3")]
		[Serializable]
		private struct PlayerSighting
		{
			// Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000972")]
			[Address(RVA = "0xFA17B0", Offset = "0xF9FDB0", VA = "0x180FA17B0")]
			public PlayerSighting(Vector3 position, float timeInHours)
			{
			}

			// Token: 0x0400079B RID: 1947
			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 _position;

			// Token: 0x0400079C RID: 1948
			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float _timeInHours;
		}

		// Token: 0x020000F4 RID: 244
		[Token(Token = "0x20000F4")]
		public class PlayerWorldStats
		{
			// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PlayerWorldStats()
			{
			}

			// Token: 0x0400079D RID: 1949
			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int CutTrees;

			// Token: 0x0400079E RID: 1950
			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int SeenInVillageCount;

			// Token: 0x0400079F RID: 1951
			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float LastSightedTimeHours;
		}
	}
}
