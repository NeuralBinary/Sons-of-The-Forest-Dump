using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using Sons.Atmosphere;
using Sons.Environment;
using Sons.Save;
using UnityEngine;
using UnityEngine.Serialization;

namespace TheForest.World
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	public class WeatherSystem : MonoBehaviour, IWindReceiver, ISeasonsReceiver, IQuitHandler, ISaveGameSerializer<WeatherSystem.WeatherSystemSaveData>
	{
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x17000343")]
		public WeatherSystem.RainType CurrentRainType
		{
			[Token(Token = "0x600184C")]
			[Address(RVA = "0x27E7B40", Offset = "0x27E6140", VA = "0x1827E7B40")]
			get
			{
				return WeatherSystem.RainType.None;
			}
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x327C580", Offset = "0x327AB80", VA = "0x18327C580")]
		public static GameObject GetRainFollowGameObject()
		{
			return null;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x327C810", Offset = "0x327AE10", VA = "0x18327C810")]
		public static RainTypes GetRainTypes()
		{
			return null;
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00007860 File Offset: 0x00005A60
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000344")]
		public float rainBowFade
		{
			[Token(Token = "0x600184F")]
			[Address(RVA = "0x327C9D0", Offset = "0x327AFD0", VA = "0x18327C9D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001850")]
			[Address(RVA = "0x327C9E0", Offset = "0x327AFE0", VA = "0x18327C9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00007878 File Offset: 0x00005A78
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000345")]
		public bool IsRaining
		{
			[Token(Token = "0x6001851")]
			[Address(RVA = "0x327C9F0", Offset = "0x327AFF0", VA = "0x18327C9F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001852")]
			[Address(RVA = "0x327CA00", Offset = "0x327B000", VA = "0x18327CA00")]
			set
			{
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00007890 File Offset: 0x00005A90
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000346")]
		public bool IsSnowing
		{
			[Token(Token = "0x6001853")]
			[Address(RVA = "0xA03DF0", Offset = "0xA023F0", VA = "0x180A03DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001854")]
			[Address(RVA = "0x327CAA0", Offset = "0x327B0A0", VA = "0x18327CAA0")]
			set
			{
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x000078A8 File Offset: 0x00005AA8
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000347")]
		public CloudState CloudStateValue
		{
			[Token(Token = "0x6001855")]
			[Address(RVA = "0xAFF540", Offset = "0xAFDB40", VA = "0x180AFF540")]
			get
			{
				return CloudState.Idle;
			}
			[Token(Token = "0x6001856")]
			[Address(RVA = "0x327CB30", Offset = "0x327B130", VA = "0x18327CB30")]
			set
			{
			}
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x327CBB0", Offset = "0x327B1B0", VA = "0x18327CBB0")]
		private void Awake()
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x327D5B0", Offset = "0x327BBB0", VA = "0x18327D5B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x327D610", Offset = "0x327BC10", VA = "0x18327D610")]
		private void Update()
		{
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x327DBA0", Offset = "0x327C1A0", VA = "0x18327DBA0")]
		private void CheckDisableFollowGroup()
		{
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x327DDA0", Offset = "0x327C3A0", VA = "0x18327DDA0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x327DE80", Offset = "0x327C480", VA = "0x18327DE80")]
		private void OnDisable()
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x327DF00", Offset = "0x327C500", VA = "0x18327DF00", Slot = "5")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x327DF90", Offset = "0x327C590", VA = "0x18327DF90", Slot = "4")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x327DFB0", Offset = "0x327C5B0", VA = "0x18327DFB0")]
		private void UpdateEnvironmentWetness()
		{
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x327E3F0", Offset = "0x327C9F0", VA = "0x18327E3F0")]
		private void UpdateRainReceivers()
		{
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x327E550", Offset = "0x327CB50", VA = "0x18327E550")]
		private void UpdateSnowingReceivers()
		{
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x327E6B0", Offset = "0x327CCB0", VA = "0x18327E6B0")]
		private void CheckForRain(float getTimeOfDayDelta)
		{
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x327E800", Offset = "0x327CE00", VA = "0x18327E800")]
		public void ForceRain(int rainDiceRoll)
		{
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x2B40070", Offset = "0x2B3E670", VA = "0x182B40070")]
		private void SetWindIntensity(float newValue)
		{
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x6001865")]
		[Address(RVA = "0x327E8A0", Offset = "0x327CEA0", VA = "0x18327E8A0")]
		private int RollForPrecipitationType()
		{
			return 0;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x327EB50", Offset = "0x327D150", VA = "0x18327EB50")]
		private static int GetRandomChange()
		{
			return 0;
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x327EBC0", Offset = "0x327D1C0", VA = "0x18327EBC0")]
		private void TryRain()
		{
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x327EBD0", Offset = "0x327D1D0", VA = "0x18327EBD0")]
		private void TryRain(bool force)
		{
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x327ECF0", Offset = "0x327D2F0", VA = "0x18327ECF0")]
		public void SetTargetStormFactor(float stormFactor)
		{
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x327ED10", Offset = "0x327D310", VA = "0x18327ED10")]
		private void StartRaining()
		{
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x327EE00", Offset = "0x327D400", VA = "0x18327EE00")]
		public void StopRaining()
		{
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x327F130", Offset = "0x327D730", VA = "0x18327F130")]
		public void CheckInCave()
		{
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x327F3A0", Offset = "0x327D9A0", VA = "0x18327F3A0")]
		private void TriggerLightning()
		{
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x327F420", Offset = "0x327DA20", VA = "0x18327F420")]
		public void PlayLightningStrike(Camera targetCamera, bool isOpeningCutscene = false)
		{
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x327FCB0", Offset = "0x327E2B0", VA = "0x18327FCB0")]
		private void LogMessage(string message)
		{
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x327FD40", Offset = "0x327E340", VA = "0x18327FD40")]
		private void TurnOffLightning()
		{
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001871")]
		[Address(RVA = "0x327FE00", Offset = "0x327E400", VA = "0x18327FE00")]
		private IEnumerator PlayFarThunderRumbles()
		{
			return null;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001872")]
		[Address(RVA = "0x327FE90", Offset = "0x327E490", VA = "0x18327FE90")]
		private IEnumerator PlayNearThunderRumbles()
		{
			return null;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001873")]
		[Address(RVA = "0x327FF20", Offset = "0x327E520", VA = "0x18327FF20")]
		public void AllOff()
		{
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001874")]
		[Address(RVA = "0x3280150", Offset = "0x327E750", VA = "0x183280150")]
		public void StartRaining(WeatherSystem.RainType rainType)
		{
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x6001875")]
		[Address(RVA = "0x3280790", Offset = "0x327ED90", VA = "0x183280790")]
		private bool ShouldSnow()
		{
			return default(bool);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001876")]
		[Address(RVA = "0x32809F0", Offset = "0x327EFF0", VA = "0x1832809F0")]
		private static void SetRainTypeActive(UnityEngine.Object target)
		{
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001877")]
		[Address(RVA = "0x3281190", Offset = "0x327F790", VA = "0x183281190")]
		private IEnumerator WatchCleanInRain()
		{
			return null;
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001878")]
		[Address(RVA = "0x3281220", Offset = "0x327F820", VA = "0x183281220")]
		public void Register(IEnvironmentWetnessAndRainReceiver receiver)
		{
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001879")]
		[Address(RVA = "0x3281290", Offset = "0x327F890", VA = "0x183281290")]
		public void UnRegister(IEnvironmentWetnessAndRainReceiver receiver)
		{
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187A")]
		[Address(RVA = "0x3281300", Offset = "0x327F900", VA = "0x183281300")]
		public void Register(IRainAndSnowingReceiver receiver)
		{
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187B")]
		[Address(RVA = "0x3281400", Offset = "0x327FA00", VA = "0x183281400")]
		public void UnRegister(IRainAndSnowingReceiver receiver)
		{
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187C")]
		[Address(RVA = "0x32814A0", Offset = "0x327FAA0", VA = "0x1832814A0")]
		public void Register(IRainReceiver receiver)
		{
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187D")]
		[Address(RVA = "0x3281550", Offset = "0x327FB50", VA = "0x183281550")]
		public void UnRegister(IRainReceiver receiver)
		{
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187E")]
		[Address(RVA = "0x32815C0", Offset = "0x327FBC0", VA = "0x1832815C0")]
		public void Register(IEnvironmentWetnessReceiver receiver)
		{
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600187F")]
		[Address(RVA = "0x3281630", Offset = "0x327FC30", VA = "0x183281630")]
		public void UnRegister(IEnvironmentWetnessReceiver receiver)
		{
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001880")]
		private static void Register<T>(T receiver, ref List<T> list)
		{
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001881")]
		private static void UnRegister<T>(T receiver, ref List<T> list)
		{
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x32816A0", Offset = "0x327FCA0", VA = "0x1832816A0")]
		public void CheckForRainToSnow()
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x32816E0", Offset = "0x327FCE0", VA = "0x1832816E0")]
		private void SetLeavesOnTerrain(float density)
		{
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001884")]
		[Address(RVA = "0x3281930", Offset = "0x327FF30", VA = "0x183281930")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x6001885")]
		[Address(RVA = "0x32819E0", Offset = "0x327FFE0", VA = "0x1832819E0")]
		private bool DebugCommandSetLightningInterval(string arguments)
		{
			return default(bool);
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x3281BA0", Offset = "0x32801A0", VA = "0x183281BA0")]
		public void SetRainBlocked(bool value)
		{
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x3281BB0", Offset = "0x32801B0", VA = "0x183281BB0", Slot = "7")]
		public void OnQuit()
		{
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000348")]
		public string SerializedName
		{
			[Token(Token = "0x6001888")]
			[Address(RVA = "0x2A3DA20", Offset = "0x2A3C020", VA = "0x182A3DA20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001889")]
			[Address(RVA = "0x3281CB0", Offset = "0x32802B0", VA = "0x183281CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x17000349")]
		private bool UniqueFile
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x1700034A")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x1700034B")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x600188C")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x3281D10", Offset = "0x3280310", VA = "0x183281D10", Slot = "9")]
		private WeatherSystem.WeatherSystemSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x3281E90", Offset = "0x3280490", VA = "0x183281E90")]
		private void OnBeforeDeserialize()
		{
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x3282040", Offset = "0x3280640", VA = "0x183282040", Slot = "10")]
		private void OnDeserialize(WeatherSystem.WeatherSystemSaveData data)
		{
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001890")]
		[Address(RVA = "0x32822C0", Offset = "0x32808C0", VA = "0x1832822C0")]
		public WeatherSystem()
		{
		}

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		public const int ClearSkyDiceValue = 0;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		public const int LightRainDiceValue = 1;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		public const int MediumRainDiceValue = 2;

		// Token: 0x04001773 RID: 6003
		[Token(Token = "0x4001773")]
		public const int HeavyRainDiceValue = 3;

		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		public const int CloudyDiceValue = 4;

		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		public const int NoChangeDiceValue = 5;

		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0x0")]
		public static WeatherSystem Instance;

		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _terrainAutumnLeavesShaderId;

		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lightningRoot;

		// Token: 0x04001779 RID: 6009
		[Token(Token = "0x4001779")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lightningLightObject;

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lightingScript;

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lightningDuration;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _farAwayThunderRumbles;

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _minFarAwayThunderRepeat;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _maxFarAwayThunderRepeat;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _nearThunderRumbles;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _minNearThunderRepeat;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _maxNearThunderRepeat;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x60")]
		public string ThunderEventPath;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _windIntensity;

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector3 _windDirection;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x78")]
		[FormerlySerializedAs("RainDice")]
		[SerializeField]
		[HideInInspector]
		private int RainDiceRoll;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x7C")]
		private float _baseTimeToWaitBeforeCheckingForRain;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("The smaller the speed the longer the rainbow will stay on screen.")]
		public float _rainbowFadeSpeed;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _triggerSnowAtDepth;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _lightRainCloudStormFactor;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _mediumRainCloudStormFactor;

		// Token: 0x0400178B RID: 6027
		[Token(Token = "0x400178B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _heavyRainCloudStormFactor;

		// Token: 0x0400178C RID: 6028
		[Token(Token = "0x400178C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CloudManager _cloudManager;

		// Token: 0x0400178D RID: 6029
		[Token(Token = "0x400178D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _wetnessTarget;

		// Token: 0x0400178E RID: 6030
		[Token(Token = "0x400178E")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _wetnessCurrent;

		// Token: 0x0400178F RID: 6031
		[Token(Token = "0x400178F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[FormerlySerializedAs("_wetnessSmoothTime")]
		private float _wetnessIncreaseSmoothTime;

		// Token: 0x04001790 RID: 6032
		[Token(Token = "0x4001790")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _wetnessDecreaseSmoothTime;

		// Token: 0x04001791 RID: 6033
		[Token(Token = "0x4001791")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<IEnvironmentWetnessReceiver> _wetnessReceivers;

		// Token: 0x04001792 RID: 6034
		[Token(Token = "0x4001792")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<IRainReceiver> _rainReceivers;

		// Token: 0x04001793 RID: 6035
		[Token(Token = "0x4001793")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<ISnowingReceiver> _snowingReceivers;

		// Token: 0x04001794 RID: 6036
		[Token(Token = "0x4001794")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<IEnvironmentWetnessAndRainReceiver> _wetnessAndRainReceivers;

		// Token: 0x04001795 RID: 6037
		[Token(Token = "0x4001795")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SnowHeightManager _snowHeightManager;

		// Token: 0x04001796 RID: 6038
		[Token(Token = "0x4001796")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Terrain _terrain;

		// Token: 0x04001797 RID: 6039
		[Token(Token = "0x4001797")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Material _terrainVisibilityMaterial;

		// Token: 0x04001798 RID: 6040
		[Token(Token = "0x4001798")]
		[FieldOffset(Offset = "0xE8")]
		private readonly float[] _rainIntensities;

		// Token: 0x04001799 RID: 6041
		[Token(Token = "0x4001799")]
		[FieldOffset(Offset = "0xF0")]
		private float _activeRainDurationSeconds;

		// Token: 0x0400179A RID: 6042
		[Token(Token = "0x400179A")]
		[FieldOffset(Offset = "0xF4")]
		private CloudState _cloudState;

		// Token: 0x0400179B RID: 6043
		[Token(Token = "0x400179B")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject _isRainingStimuliObject;

		// Token: 0x0400179C RID: 6044
		[Token(Token = "0x400179C")]
		[FieldOffset(Offset = "0x100")]
		private bool _isSnowing;

		// Token: 0x0400179D RID: 6045
		[Token(Token = "0x400179D")]
		[FieldOffset(Offset = "0x108")]
		private GameObject _isSnowingStimuliObject;

		// Token: 0x0400179E RID: 6046
		[Token(Token = "0x400179E")]
		[FieldOffset(Offset = "0x110")]
		private TimeOfDay _rainStartTime;

		// Token: 0x0400179F RID: 6047
		[Token(Token = "0x400179F")]
		[FieldOffset(Offset = "0x130")]
		private WeatherSystem.RainType _currentRainType;

		// Token: 0x040017A0 RID: 6048
		[Token(Token = "0x40017A0")]
		[FieldOffset(Offset = "0x134")]
		private float _wetnessVelocity;

		// Token: 0x040017A1 RID: 6049
		[Token(Token = "0x40017A1")]
		[FieldOffset(Offset = "0x138")]
		private bool _rainBlocked;

		// Token: 0x040017A2 RID: 6050
		[Token(Token = "0x40017A2")]
		[FieldOffset(Offset = "0x13C")]
		private int _shouldSnowCachedFrame;

		// Token: 0x040017A3 RID: 6051
		[Token(Token = "0x40017A3")]
		[FieldOffset(Offset = "0x140")]
		private bool _shouldSnowCached;

		// Token: 0x040017A4 RID: 6052
		[Token(Token = "0x40017A4")]
		[FieldOffset(Offset = "0x144")]
		private SeasonsManager.Season _currentSeason;

		// Token: 0x040017A5 RID: 6053
		[Token(Token = "0x40017A5")]
		[FieldOffset(Offset = "0x10")]
		private static GameObject _rainFollowGameObjectCache;

		// Token: 0x040017A6 RID: 6054
		[Token(Token = "0x40017A6")]
		[FieldOffset(Offset = "0x18")]
		private static RainTypes _rainTypesCache;

		// Token: 0x040017A7 RID: 6055
		[Token(Token = "0x40017A7")]
		[FieldOffset(Offset = "0x148")]
		private EventInstance _nearThunderEventInstance;

		// Token: 0x040017A8 RID: 6056
		[Token(Token = "0x40017A8")]
		[FieldOffset(Offset = "0x150")]
		private EventInstance _farThunderEventInstance;

		// Token: 0x040017A9 RID: 6057
		[Token(Token = "0x40017A9")]
		[FieldOffset(Offset = "0x158")]
		private bool _quitting;

		// Token: 0x02000393 RID: 915
		[Token(Token = "0x2000393")]
		public enum RainType
		{
			// Token: 0x040017AD RID: 6061
			[Token(Token = "0x40017AD")]
			None,
			// Token: 0x040017AE RID: 6062
			[Token(Token = "0x40017AE")]
			Light,
			// Token: 0x040017AF RID: 6063
			[Token(Token = "0x40017AF")]
			Medium,
			// Token: 0x040017B0 RID: 6064
			[Token(Token = "0x40017B0")]
			Heavy
		}

		// Token: 0x02000394 RID: 916
		[Token(Token = "0x2000394")]
		[Serializable]
		internal class WeatherSystemSaveData
		{
			// Token: 0x06001892 RID: 6290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001892")]
			[Address(RVA = "0x32827B0", Offset = "0x3280DB0", VA = "0x1832827B0")]
			public WeatherSystemSaveData()
			{
			}

			// Token: 0x040017B1 RID: 6065
			[Token(Token = "0x40017B1")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x040017B2 RID: 6066
			[Token(Token = "0x40017B2")]
			[FieldOffset(Offset = "0x18")]
			public bool _isRaining;

			// Token: 0x040017B3 RID: 6067
			[Token(Token = "0x40017B3")]
			[FieldOffset(Offset = "0x19")]
			public bool _rainBlocked;

			// Token: 0x040017B4 RID: 6068
			[Token(Token = "0x40017B4")]
			[FieldOffset(Offset = "0x1C")]
			public int _cloudState;

			// Token: 0x040017B5 RID: 6069
			[Token(Token = "0x40017B5")]
			[FieldOffset(Offset = "0x20")]
			public int _currentRainType;

			// Token: 0x040017B6 RID: 6070
			[Token(Token = "0x40017B6")]
			[FieldOffset(Offset = "0x24")]
			public int _currentSeason;

			// Token: 0x040017B7 RID: 6071
			[Token(Token = "0x40017B7")]
			[FieldOffset(Offset = "0x28")]
			public float _startingDayOffset;

			// Token: 0x040017B8 RID: 6072
			[Token(Token = "0x40017B8")]
			[FieldOffset(Offset = "0x2C")]
			public float _wetnessVelocity;

			// Token: 0x040017B9 RID: 6073
			[Token(Token = "0x40017B9")]
			[FieldOffset(Offset = "0x30")]
			public float _wetnessCurrent;

			// Token: 0x040017BA RID: 6074
			[Token(Token = "0x40017BA")]
			[FieldOffset(Offset = "0x34")]
			public float _wetnessTarget;
		}
	}
}
