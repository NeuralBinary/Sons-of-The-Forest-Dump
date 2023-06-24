using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200007E RID: 126
[Token(Token = "0x200007E")]
public interface IWeatherState : IState, IDisposable
{
	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000419 RID: 1049
	// (set) Token: 0x0600041A RID: 1050
	[Token(Token = "0x17000212")]
	float Temp { [Token(Token = "0x6000419")] get; [Token(Token = "0x600041A")] set; }

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x0600041B RID: 1051
	// (set) Token: 0x0600041C RID: 1052
	[Token(Token = "0x17000213")]
	float ElapsedGameTime { [Token(Token = "0x600041B")] get; [Token(Token = "0x600041C")] set; }

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x0600041D RID: 1053
	// (set) Token: 0x0600041E RID: 1054
	[Token(Token = "0x17000214")]
	int RainType { [Token(Token = "0x600041D")] get; [Token(Token = "0x600041E")] set; }

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x0600041F RID: 1055
	// (set) Token: 0x06000420 RID: 1056
	[Token(Token = "0x17000215")]
	int CloudState { [Token(Token = "0x600041F")] get; [Token(Token = "0x6000420")] set; }

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000421 RID: 1057
	[Token(Token = "0x17000216")]
	NetworkArray_Float Wind { [Token(Token = "0x6000421")] get; }

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000422 RID: 1058
	// (set) Token: 0x06000423 RID: 1059
	[Token(Token = "0x17000217")]
	bool Rainbow { [Token(Token = "0x6000422")] get; [Token(Token = "0x6000423")] set; }

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000424 RID: 1060
	// (set) Token: 0x06000425 RID: 1061
	[Token(Token = "0x17000218")]
	Color RainbowIntensity { [Token(Token = "0x6000424")] get; [Token(Token = "0x6000425")] set; }

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000426 RID: 1062
	// (set) Token: 0x06000427 RID: 1063
	[Token(Token = "0x17000219")]
	bool AfterStorm { [Token(Token = "0x6000426")] get; [Token(Token = "0x6000427")] set; }

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000428 RID: 1064
	// (set) Token: 0x06000429 RID: 1065
	[Token(Token = "0x1700021A")]
	bool NightTimeSfx { [Token(Token = "0x6000428")] get; [Token(Token = "0x6000429")] set; }

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x0600042A RID: 1066
	// (set) Token: 0x0600042B RID: 1067
	[Token(Token = "0x1700021B")]
	bool DayTimeSfx { [Token(Token = "0x600042A")] get; [Token(Token = "0x600042B")] set; }

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x0600042C RID: 1068
	// (set) Token: 0x0600042D RID: 1069
	[Token(Token = "0x1700021C")]
	bool Lightning { [Token(Token = "0x600042C")] get; [Token(Token = "0x600042D")] set; }

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x0600042E RID: 1070
	// (set) Token: 0x0600042F RID: 1071
	[Token(Token = "0x1700021D")]
	float TargetStormFactor { [Token(Token = "0x600042E")] get; [Token(Token = "0x600042F")] set; }

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000430 RID: 1072
	// (set) Token: 0x06000431 RID: 1073
	[Token(Token = "0x1700021E")]
	float CloudOpacityScaleTarget { [Token(Token = "0x6000430")] get; [Token(Token = "0x6000431")] set; }
}
