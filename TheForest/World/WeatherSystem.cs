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
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	public class WeatherSystem : MonoBehaviour, IWindReceiver, ISeasonsReceiver, IQuitHandler, ISaveGameSerializer<WeatherSystem.WeatherSystemSaveData>
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x1700033B")]
		public WeatherSystem.RainType CurrentRainType
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x2383D40", Offset = "0x2382D40", VA = "0x182383D40")]
			get
			{
				return WeatherSystem.RainType.None;
			}
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x2CD9D30", Offset = "0x2CD8D30", VA = "0x182CD9D30")]
		public static GameObject GetRainFollowGameObject()
		{
			return null;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x2CD9E90", Offset = "0x2CD8E90", VA = "0x182CD9E90")]
		public static RainTypes GetRainTypes()
		{
			return null;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x000075F0 File Offset: 0x000057F0
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033C")]
		public float rainBowFade
		{
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x2CDD350", Offset = "0x2CDC350", VA = "0x182CDD350")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x2CDD4A0", Offset = "0x2CDC4A0", VA = "0x182CDD4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00007608 File Offset: 0x00005808
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033D")]
		public bool IsRaining
		{
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x2CDD340", Offset = "0x2CDC340", VA = "0x182CDD340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x2CDD3E0", Offset = "0x2CDC3E0", VA = "0x182CDD3E0")]
			set
			{
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00007620 File Offset: 0x00005820
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033E")]
		public bool IsSnowing
		{
			[Token(Token = "0x6001818")]
			[Address(RVA = "0x8C5E70", Offset = "0x8C4E70", VA = "0x1808C5E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x2CDD440", Offset = "0x2CDC440", VA = "0x182CDD440")]
			set
			{
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00007638 File Offset: 0x00005838
		// (set) Token: 0x0600181B RID: 6171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033F")]
		public CloudState CloudStateValue
		{
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x986620", Offset = "0x985620", VA = "0x180986620")]
			get
			{
				return default(CloudState);
			}
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x2CDD360", Offset = "0x2CDC360", VA = "0x182CDD360")]
			set
			{
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181C")]
		[Address(RVA = "0x2CD90D0", Offset = "0x2CD80D0", VA = "0x182CD90D0")]
		private void Awake()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181D")]
		[Address(RVA = "0x2CDA1B0", Offset = "0x2CD91B0", VA = "0x182CDA1B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181E")]
		[Address(RVA = "0x2CDCB20", Offset = "0x2CDBB20", VA = "0x182CDCB20")]
		private void Update()
		{
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600181F")]
		[Address(RVA = "0x2CD96C0", Offset = "0x2CD86C0", VA = "0x182CD96C0")]
		private void CheckDisableFollowGroup()
		{
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001820")]
		[Address(RVA = "0x2CDA290", Offset = "0x2CD9290", VA = "0x182CDA290")]
		private void OnEnable()
		{
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001821")]
		[Address(RVA = "0x2CDA210", Offset = "0x2CD9210", VA = "0x182CDA210")]
		private void OnDisable()
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001822")]
		[Address(RVA = "0x2CDAE50", Offset = "0x2CD9E50", VA = "0x182CDAE50", Slot = "5")]
		public void SeasonChanged(SeasonProperties seasonProperties)
		{
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001823")]
		[Address(RVA = "0x2CDCB00", Offset = "0x2CDBB00", VA = "0x182CDCB00", Slot = "4")]
		public void UpdateWind(Vector3 direction, float intensity)
		{
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x2CDC4F0", Offset = "0x2CDB4F0", VA = "0x182CDC4F0")]
		private void UpdateEnvironmentWetness()
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x2CDC8C0", Offset = "0x2CDB8C0", VA = "0x182CDC8C0")]
		private void UpdateRainReceivers()
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x2CDC9E0", Offset = "0x2CDB9E0", VA = "0x182CDC9E0")]
		private void UpdateSnowingReceivers()
		{
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x2CD9810", Offset = "0x2CD8810", VA = "0x182CD9810")]
		private void CheckForRain(float getTimeOfDayDelta)
		{
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x2CD9CC0", Offset = "0x2CD8CC0", VA = "0x182CD9CC0")]
		public void ForceRain(int rainDiceRoll)
		{
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x264F560", Offset = "0x264E560", VA = "0x18264F560")]
		private void SetWindIntensity(float newValue)
		{
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x2CDACE0", Offset = "0x2CD9CE0", VA = "0x182CDACE0")]
		private int RollForPrecipitationType()
		{
			return default(int);
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x600182B")]
		[Address(RVA = "0x2CD9FC0", Offset = "0x2CD8FC0", VA = "0x182CD9FC0")]
		private static int GetRandomChange()
		{
			return default(int);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x2CDC190", Offset = "0x2CDB190", VA = "0x182CDC190")]
		private void TryRain()
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x2CDC1A0", Offset = "0x2CDB1A0", VA = "0x182CDC1A0")]
		private void TryRain(bool force)
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x2CDB3F0", Offset = "0x2CDA3F0", VA = "0x182CDB3F0")]
		public void SetTargetStormFactor(float stormFactor)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x2CDBEC0", Offset = "0x2CDAEC0", VA = "0x182CDBEC0")]
		private void StartRaining()
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x2CDBF80", Offset = "0x2CDAF80", VA = "0x182CDBF80")]
		public void StopRaining()
		{
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x2CD9A50", Offset = "0x2CD8A50", VA = "0x182CD9A50")]
		public void CheckInCave()
		{
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x2CDC110", Offset = "0x2CDB110", VA = "0x182CDC110")]
		private void TriggerLightning()
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x2CDA450", Offset = "0x2CD9450", VA = "0x182CDA450")]
		public void PlayLightningStrike(Camera targetCamera, bool isOpeningCutscene = false)
		{
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x2CD9FF0", Offset = "0x2CD8FF0", VA = "0x182CD9FF0")]
		private void LogMessage(string message)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x2CDC2C0", Offset = "0x2CDB2C0", VA = "0x182CDC2C0")]
		private void TurnOffLightning()
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x2CDA3E0", Offset = "0x2CD93E0", VA = "0x182CDA3E0")]
		private IEnumerator PlayFarThunderRumbles()
		{
			return null;
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x2CDA9E0", Offset = "0x2CD99E0", VA = "0x182CDA9E0")]
		private IEnumerator PlayNearThunderRumbles()
		{
			return null;
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x2CD8FA0", Offset = "0x2CD7FA0", VA = "0x182CD8FA0")]
		public void AllOff()
		{
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x2CDB990", Offset = "0x2CDA990", VA = "0x182CDB990")]
		public void StartRaining(WeatherSystem.RainType rainType)
		{
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x2CDB4C0", Offset = "0x2CDA4C0", VA = "0x182CDB4C0")]
		private bool ShouldSnow()
		{
			return default(bool);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x2CDB1B0", Offset = "0x2CDA1B0", VA = "0x182CDB1B0")]
		private static void SetRainTypeActive(Object target)
		{
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x2CDCFD0", Offset = "0x2CDBFD0", VA = "0x182CDCFD0")]
		private IEnumerator WatchCleanInRain()
		{
			return null;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x2CDAA50", Offset = "0x2CD9A50", VA = "0x182CDAA50")]
		public void Register(IEnvironmentWetnessAndRainReceiver receiver)
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x2CDC480", Offset = "0x2CDB480", VA = "0x182CDC480")]
		public void UnRegister(IEnvironmentWetnessAndRainReceiver receiver)
		{
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x2CDAAC0", Offset = "0x2CD9AC0", VA = "0x182CDAAC0")]
		public void Register(IRainAndSnowingReceiver receiver)
		{
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x2CDC3E0", Offset = "0x2CDB3E0", VA = "0x182CDC3E0")]
		public void UnRegister(IRainAndSnowingReceiver receiver)
		{
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x2CDABC0", Offset = "0x2CD9BC0", VA = "0x182CDABC0")]
		public void Register(IRainReceiver receiver)
		{
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x2CDC300", Offset = "0x2CDB300", VA = "0x182CDC300")]
		public void UnRegister(IRainReceiver receiver)
		{
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x2CDAC70", Offset = "0x2CD9C70", VA = "0x182CDAC70")]
		public void Register(IEnvironmentWetnessReceiver receiver)
		{
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x2CDC370", Offset = "0x2CDB370", VA = "0x182CDC370")]
		public void UnRegister(IEnvironmentWetnessReceiver receiver)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001845")]
		private static void Register<T>(T receiver, ref List<T> list)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001846")]
		private static void UnRegister<T>(T receiver, ref List<T> list)
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x2CD97D0", Offset = "0x2CD87D0", VA = "0x182CD97D0")]
		public void CheckForRainToSnow()
		{
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x2CDB050", Offset = "0x2CDA050", VA = "0x182CDB050")]
		private void SetLeavesOnTerrain(float density)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x2CDB410", Offset = "0x2CDA410", VA = "0x182CDB410")]
		private void SetupDebugCommands()
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x2CD9C10", Offset = "0x2CD8C10", VA = "0x182CD9C10")]
		private bool DebugCommandSetLightningInterval(string arguments)
		{
			return default(bool);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x2CDB1A0", Offset = "0x2CDA1A0", VA = "0x182CDB1A0")]
		public void SetRainBlocked(bool value)
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x2CDA370", Offset = "0x2CD9370", VA = "0x182CDA370", Slot = "7")]
		public void OnQuit()
		{
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000340")]
		public string SerializedName
		{
			[Token(Token = "0x600184D")]
			[Address(RVA = "0x25754B0", Offset = "0x25744B0", VA = "0x1825754B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600184E")]
			[Address(RVA = "0x2CDD490", Offset = "0x2CDC490", VA = "0x182CDD490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x17000341")]
		private bool UniqueFile
		{
			[Token(Token = "0x600184F")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x17000342")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6001850")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x17000343")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6001851")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x2CDB840", Offset = "0x2CDA840", VA = "0x182CDB840", Slot = "9")]
		private WeatherSystem.WeatherSystemSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x2CDA080", Offset = "0x2CD9080", VA = "0x182CDA080")]
		private void OnBeforeDeserialize()
		{
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x2CDB690", Offset = "0x2CDA690", VA = "0x182CDB690", Slot = "10")]
		private void OnDeserialize(WeatherSystem.WeatherSystemSaveData data)
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x2CDD090", Offset = "0x2CDC090", VA = "0x182CDD090")]
		public WeatherSystem()
		{
		}

		// Token: 0x04001751 RID: 5969
		[Token(Token = "0x4001751")]
		public const int ClearSkyDiceValue = 0;

		// Token: 0x04001752 RID: 5970
		[Token(Token = "0x4001752")]
		public const int LightRainDiceValue = 1;

		// Token: 0x04001753 RID: 5971
		[Token(Token = "0x4001753")]
		public const int MediumRainDiceValue = 2;

		// Token: 0x04001754 RID: 5972
		[Token(Token = "0x4001754")]
		public const int HeavyRainDiceValue = 3;

		// Token: 0x04001755 RID: 5973
		[Token(Token = "0x4001755")]
		public const int CloudyDiceValue = 4;

		// Token: 0x04001756 RID: 5974
		[Token(Token = "0x4001756")]
		public const int NoChangeDiceValue = 5;

		// Token: 0x04001757 RID: 5975
		[Token(Token = "0x4001757")]
		[FieldOffset(Offset = "0x0")]
		public static WeatherSystem Instance;

		// Token: 0x04001758 RID: 5976
		[Token(Token = "0x4001758")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _terrainAutumnLeavesShaderId;

		// Token: 0x04001759 RID: 5977
		[Token(Token = "0x4001759")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lightningRoot;

		// Token: 0x0400175A RID: 5978
		[Token(Token = "0x400175A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lightningLightObject;

		// Token: 0x0400175B RID: 5979
		[Token(Token = "0x400175B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lightingScript;

		// Token: 0x0400175C RID: 5980
		[Token(Token = "0x400175C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _lightningDuration;

		// Token: 0x0400175D RID: 5981
		[Token(Token = "0x400175D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _farAwayThunderRumbles;

		// Token: 0x0400175E RID: 5982
		[Token(Token = "0x400175E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _minFarAwayThunderRepeat;

		// Token: 0x0400175F RID: 5983
		[Token(Token = "0x400175F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _maxFarAwayThunderRepeat;

		// Token: 0x04001760 RID: 5984
		[Token(Token = "0x4001760")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _nearThunderRumbles;

		// Token: 0x04001761 RID: 5985
		[Token(Token = "0x4001761")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _minNearThunderRepeat;

		// Token: 0x04001762 RID: 5986
		[Token(Token = "0x4001762")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _maxNearThunderRepeat;

		// Token: 0x04001763 RID: 5987
		[Token(Token = "0x4001763")]
		[FieldOffset(Offset = "0x60")]
		public string ThunderEventPath;

		// Token: 0x04001764 RID: 5988
		[Token(Token = "0x4001764")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _windIntensity;

		// Token: 0x04001765 RID: 5989
		[Token(Token = "0x4001765")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector3 _windDirection;

		// Token: 0x04001766 RID: 5990
		[Token(Token = "0x4001766")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[FormerlySerializedAs("RainDice")]
		[HideInInspector]
		private int RainDiceRoll;

		// Token: 0x04001767 RID: 5991
		[Token(Token = "0x4001767")]
		[FieldOffset(Offset = "0x7C")]
		private float _baseTimeToWaitBeforeCheckingForRain;

		// Token: 0x04001768 RID: 5992
		[Token(Token = "0x4001768")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("The smaller the speed the longer the rainbow will stay on screen.")]
		[SerializeField]
		public float _rainbowFadeSpeed;

		// Token: 0x04001769 RID: 5993
		[Token(Token = "0x4001769")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _triggerSnowAtDepth;

		// Token: 0x0400176A RID: 5994
		[Token(Token = "0x400176A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _lightRainCloudStormFactor;

		// Token: 0x0400176B RID: 5995
		[Token(Token = "0x400176B")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _mediumRainCloudStormFactor;

		// Token: 0x0400176C RID: 5996
		[Token(Token = "0x400176C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _heavyRainCloudStormFactor;

		// Token: 0x0400176D RID: 5997
		[Token(Token = "0x400176D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CloudManager _cloudManager;

		// Token: 0x0400176E RID: 5998
		[Token(Token = "0x400176E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _wetnessTarget;

		// Token: 0x0400176F RID: 5999
		[Token(Token = "0x400176F")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float _wetnessCurrent;

		// Token: 0x04001770 RID: 6000
		[Token(Token = "0x4001770")]
		[FieldOffset(Offset = "0xA8")]
		[FormerlySerializedAs("_wetnessSmoothTime")]
		[SerializeField]
		private float _wetnessIncreaseSmoothTime;

		// Token: 0x04001771 RID: 6001
		[Token(Token = "0x4001771")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _wetnessDecreaseSmoothTime;

		// Token: 0x04001772 RID: 6002
		[Token(Token = "0x4001772")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<IEnvironmentWetnessReceiver> _wetnessReceivers;

		// Token: 0x04001773 RID: 6003
		[Token(Token = "0x4001773")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private List<IRainReceiver> _rainReceivers;

		// Token: 0x04001774 RID: 6004
		[Token(Token = "0x4001774")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<ISnowingReceiver> _snowingReceivers;

		// Token: 0x04001775 RID: 6005
		[Token(Token = "0x4001775")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private List<IEnvironmentWetnessAndRainReceiver> _wetnessAndRainReceivers;

		// Token: 0x04001776 RID: 6006
		[Token(Token = "0x4001776")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private SnowHeightManager _snowHeightManager;

		// Token: 0x04001777 RID: 6007
		[Token(Token = "0x4001777")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Terrain _terrain;

		// Token: 0x04001778 RID: 6008
		[Token(Token = "0x4001778")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Material _terrainVisibilityMaterial;

		// Token: 0x04001779 RID: 6009
		[Token(Token = "0x4001779")]
		[FieldOffset(Offset = "0xE8")]
		private readonly float[] _rainIntensities;

		// Token: 0x0400177A RID: 6010
		[Token(Token = "0x400177A")]
		[FieldOffset(Offset = "0xF0")]
		private float _activeRainDurationSeconds;

		// Token: 0x0400177B RID: 6011
		[Token(Token = "0x400177B")]
		[FieldOffset(Offset = "0xF4")]
		private CloudState _cloudState;

		// Token: 0x0400177C RID: 6012
		[Token(Token = "0x400177C")]
		[FieldOffset(Offset = "0xF8")]
		private GameObject _isRainingStimuliObject;

		// Token: 0x0400177D RID: 6013
		[Token(Token = "0x400177D")]
		[FieldOffset(Offset = "0x100")]
		private bool _isSnowing;

		// Token: 0x0400177E RID: 6014
		[Token(Token = "0x400177E")]
		[FieldOffset(Offset = "0x108")]
		private GameObject _isSnowingStimuliObject;

		// Token: 0x0400177F RID: 6015
		[Token(Token = "0x400177F")]
		[FieldOffset(Offset = "0x110")]
		private TimeOfDay _rainStartTime;

		// Token: 0x04001780 RID: 6016
		[Token(Token = "0x4001780")]
		[FieldOffset(Offset = "0x130")]
		private WeatherSystem.RainType _currentRainType;

		// Token: 0x04001781 RID: 6017
		[Token(Token = "0x4001781")]
		[FieldOffset(Offset = "0x134")]
		private float _wetnessVelocity;

		// Token: 0x04001782 RID: 6018
		[Token(Token = "0x4001782")]
		[FieldOffset(Offset = "0x138")]
		private bool _rainBlocked;

		// Token: 0x04001783 RID: 6019
		[Token(Token = "0x4001783")]
		[FieldOffset(Offset = "0x13C")]
		private int _shouldSnowCachedFrame;

		// Token: 0x04001784 RID: 6020
		[Token(Token = "0x4001784")]
		[FieldOffset(Offset = "0x140")]
		private bool _shouldSnowCached;

		// Token: 0x04001785 RID: 6021
		[Token(Token = "0x4001785")]
		[FieldOffset(Offset = "0x144")]
		private SeasonsManager.Season _currentSeason;

		// Token: 0x04001786 RID: 6022
		[Token(Token = "0x4001786")]
		[FieldOffset(Offset = "0x10")]
		private static GameObject _rainFollowGameObjectCache;

		// Token: 0x04001787 RID: 6023
		[Token(Token = "0x4001787")]
		[FieldOffset(Offset = "0x18")]
		private static RainTypes _rainTypesCache;

		// Token: 0x04001788 RID: 6024
		[Token(Token = "0x4001788")]
		[FieldOffset(Offset = "0x148")]
		private EventInstance _nearThunderEventInstance;

		// Token: 0x04001789 RID: 6025
		[Token(Token = "0x4001789")]
		[FieldOffset(Offset = "0x150")]
		private EventInstance _farThunderEventInstance;

		// Token: 0x0400178A RID: 6026
		[Token(Token = "0x400178A")]
		[FieldOffset(Offset = "0x158")]
		private bool _quitting;

		// Token: 0x020003A1 RID: 929
		[Token(Token = "0x20003A1")]
		public enum RainType
		{
			// Token: 0x0400178E RID: 6030
			[Token(Token = "0x400178E")]
			None,
			// Token: 0x0400178F RID: 6031
			[Token(Token = "0x400178F")]
			Light,
			// Token: 0x04001790 RID: 6032
			[Token(Token = "0x4001790")]
			Medium,
			// Token: 0x04001791 RID: 6033
			[Token(Token = "0x4001791")]
			Heavy
		}

		// Token: 0x020003A2 RID: 930
		[Token(Token = "0x20003A2")]
		[Serializable]
		internal class WeatherSystemSaveData
		{
			// Token: 0x06001857 RID: 6231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001857")]
			[Address(RVA = "0x2CD8F50", Offset = "0x2CD7F50", VA = "0x182CD8F50")]
			public WeatherSystemSaveData()
			{
			}

			// Token: 0x04001792 RID: 6034
			[Token(Token = "0x4001792")]
			[FieldOffset(Offset = "0x10")]
			public string Version;

			// Token: 0x04001793 RID: 6035
			[Token(Token = "0x4001793")]
			[FieldOffset(Offset = "0x18")]
			public bool _isRaining;

			// Token: 0x04001794 RID: 6036
			[Token(Token = "0x4001794")]
			[FieldOffset(Offset = "0x19")]
			public bool _rainBlocked;

			// Token: 0x04001795 RID: 6037
			[Token(Token = "0x4001795")]
			[FieldOffset(Offset = "0x1C")]
			public int _cloudState;

			// Token: 0x04001796 RID: 6038
			[Token(Token = "0x4001796")]
			[FieldOffset(Offset = "0x20")]
			public int _currentRainType;

			// Token: 0x04001797 RID: 6039
			[Token(Token = "0x4001797")]
			[FieldOffset(Offset = "0x24")]
			public int _currentSeason;

			// Token: 0x04001798 RID: 6040
			[Token(Token = "0x4001798")]
			[FieldOffset(Offset = "0x28")]
			public float _startingDayOffset;

			// Token: 0x04001799 RID: 6041
			[Token(Token = "0x4001799")]
			[FieldOffset(Offset = "0x2C")]
			public float _wetnessVelocity;

			// Token: 0x0400179A RID: 6042
			[Token(Token = "0x400179A")]
			[FieldOffset(Offset = "0x30")]
			public float _wetnessCurrent;

			// Token: 0x0400179B RID: 6043
			[Token(Token = "0x400179B")]
			[FieldOffset(Offset = "0x34")]
			public float _wetnessTarget;
		}
	}
}
