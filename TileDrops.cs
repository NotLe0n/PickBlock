using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace PickBlock;

// Code modified from Terraria src
internal static class TileDrops
{
	public static void KillTile_GetItemDrops(int x, int y, Tile tileCache, out int dropItem, out int dropItemStack, out int secondaryItem, out int secondaryItemStack, bool includeLargeObjectDrops = false)
	{
		dropItem = 0;
		dropItemStack = 1;
		secondaryItem = 0;
		secondaryItemStack = 1;
		if (includeLargeObjectDrops)
		{
			switch (tileCache.TileType)
			{
				case 21:
				case 467:
					dropItem = GetChestItemDrop(tileCache, tileCache.TileType);
					break;
				case 88:
					dropItem = GetDresserItemDrop(tileCache);
					break;
			}
		}

		int tileFrameY;

		switch (tileCache.TileType)
		{
			case TileID.ClosedDoor:
			case TileID.OpenDoor:
			case TileID.Heart:
			case TileID.Tables:
			case TileID.Chairs:
			case TileID.Anvils:
			case TileID.Furnaces:
			case TileID.WorkBenches:
			case 20:
			case 21:
			case 26:
			case 27:
			case 28:
			case 29:
			case 31:
			case 32:
			case 34:
			case 35:
			case 42:
			case 55:
			case 69:
			case 77:
			case 79:
			case 82:
				break;
			case 85:
				int style = tileCache.TileFrameX / 36;

				switch (style)
				{
					case 0:
						dropItem = 321;
						break;
					case 1:
						dropItem = 1173;
						break;
					case 2:
						dropItem = 1174;
						break;
					case 3:
						dropItem = 1175;
						break;
					case 4:
						dropItem = 1176;
						break;
					case 5:
						dropItem = 1177;
						break;
					case 6:
						dropItem = 3229;
						break;
					case 7:
						dropItem = 3230;
						break;
					case 8:
						dropItem = 3231;
						break;
					case 9:
						dropItem = 3232;
						break;
					case 10:
						dropItem = 3233;
						break;
					default:
						break;
				}
				break;
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 103:
			case 104:
			case 105:
			case 106:
			case 113:
			case 114:
			case 115:
			case 125:
			case 126:
			case 127:
			case 128:
			case 132:
			case 133:
			case 134:
			case 138:
			case 139:
			case 142:
			case 143:
			case 162:
			case 165:
			case 172:
			case 173:
			case 184:
			case 185:
			case 186:
			case 187:
			case 192:
			case 205:
			case 207:
			case 209:
			case 212:
			case 215:
			case 216:
			case 217:
			case 218:
			case 219:
			case 220:
			case 228:
			case 231:
			case 233:
			case 235:
			case 236:
			case 237:
			case 238:
			case 240:
			case 241:
			case 242:
			case 243:
			case 244:
			case 245:
			case 246:
			case 247:
			case 254:
			case 269:
			case 270:
			case 271:
			case 275:
			case 276:
			case 277:
			case 278:
			case 279:
			case 280:
			case 281:
			case 282:
			case 283:
			case 285:
			case 286:
			case 287:
			case 288:
			case 289:
			case 290:
			case 291:
			case 292:
			case 293:
			case 294:
			case 295:
			case 296:
			case 297:
			case 298:
			case 299:
			case 300:
			case 301:
			case 302:
			case 303:
			case 304:
			case 305:
			case 306:
			case 307:
			case 308:
			case 309:
			case 310:
			case 316:
			case 317:
			case 318:
			case 319:
			case 320:
			case 334:
			case 335:
			case 337:
			case 338:
			case 339:
			case 349:
			case 352:
			case 354:
			case 355:
			case 356:
			case 358:
			case 359:
			case 360:
			case 361:
			case 362:
			case 363:
			case 364:
			case 373:
			case 374:
			case 375:
			case 376:
			case 377:
			case 378:
			case 384:
			case 386:
			case 387:
			case 388:
			case 389:
			case 390:
			case 391:
			case 392:
			case 393:
			case 394:
			case 395:
			case 405:
			case 406:
			case 410:
			case 411:
			case 412:
			case 413:
			case 414:
			case 425:
			case 440:
			case 441:
			case 443:
			case 444:
			case 452:
			case 453:
			case 454:
			case 455:
			case 456:
			case 457:
			case 461:
			case 462:
			case 463:
			case 464:
			case 465:
			case 466:
			case 467:
			case 468:
			case 469:
			case 470:
			case 471:
			case 475:
			case 480:
			case 481:
			case 482:
			case 483:
			case 484:
			case 485:
			case 486:
			case 487:
			case 488:
			case 489:
			case 490:
			case 491:
			case 493:
			case 497:
			case 499:
			case 504:
			case 505:
			case 506:
			case 509:
			case 510:
			case 511:
			case 518:
			case 521:
			case 522:
			case 523:
			case 524:
			case 525:
			case 526:
			case 527:
			case 529:
			case 530:
			case 531:
			case 532:
			case 533:
			case 538:
			case 542:
			case 543:
			case 544:
			case 545:
			case 547:
			case 548:
			case 549:
			case 550:
			case 551:
			case 552:
			case 553:
			case 554:
			case 555:
			case 556:
			case 558:
			case 559:
			case 560:
			case 564:
			case 565:
			case 567:
			case 568:
			case 569:
			case 570:
			case 572:
			case 573:
			case 580:
			case 581:
			case 582:
			case 590:
			case 591:
			case 592:
			case 594:
			case 595:
			case 597:
			case 598:
			case 599:
			case 600:
			case 601:
			case 602:
			case 603:
			case 604:
			case 605:
			case 606:
			case 607:
			case 608:
			case 609:
			case 610:
			case 611:
			case 612:
			case 613:
			case 614:
			case 615:
			case 617:
				break;
			case 179:
			case 180:
			case 181:
			case 182:
			case 183:
			case 381:
			case 534:
			case 536:
			case 539:
				dropItem = ItemID.StoneBlock;
				break;
			case 512:
			case 513:
			case 514:
			case 515:
			case 516:
			case 517:
			case 535:
			case 537:
			case 540:
				dropItem = ItemID.GrayBrick;
				break;
			case 0:
			case 2:
			case 109:
			case 199:
			case 477:
			case 492:
				dropItem = ItemID.DirtBlock;
				break;
			case 426:
				dropItem = 3621;
				break;
			case 430:
				dropItem = 3633;
				break;
			case 431:
				dropItem = 3634;
				break;
			case 432:
				dropItem = 3635;
				break;
			case 433:
				dropItem = 3636;
				break;
			case 434:
				dropItem = 3637;
				break;
			case 427:
				dropItem = 3622;
				break;
			case 435:
				dropItem = 3638;
				break;
			case 436:
				dropItem = 3639;
				break;
			case 437:
				dropItem = 3640;
				break;
			case 438:
				dropItem = 3641;
				break;
			case 439:
				dropItem = 3642;
				break;
			case 446:
				dropItem = 3736;
				break;
			case 447:
				dropItem = 3737;
				break;
			case 448:
				dropItem = 3738;
				break;
			case 449:
				dropItem = 3739;
				break;
			case 450:
				dropItem = 3740;
				break;
			case 451:
				dropItem = 3741;
				break;
			case 368:
				dropItem = 3086;
				break;
			case 369:
				dropItem = 3087;
				break;
			case 367:
				dropItem = 3081;
				break;
			case 379:
				dropItem = 3214;
				break;
			case 353:
				dropItem = 2996;
				break;
			case 365:
				dropItem = 3077;
				break;
			case 366:
				dropItem = 3078;
				break;
			case 357:
				dropItem = 3066;
				break;
			case 1:
				dropItem = 3;
				break;
			case 442:
				dropItem = 3707;
				break;
			case 383:
				dropItem = 620;
				break;
			case 315:
				dropItem = 2435;
				break;
			case 330:
				dropItem = 71;
				break;
			case 331:
				dropItem = 72;
				break;
			case 332:
				dropItem = 73;
				break;
			case 333:
				dropItem = 74;
				break;
			case 408:
				dropItem = 3460;
				break;
			case 409:
				dropItem = 3461;
				break;
			case 415:
				dropItem = 3573;
				break;
			case 416:
				dropItem = 3574;
				break;
			case 417:
				dropItem = 3575;
				break;
			case 418:
				dropItem = 3576;
				break;
			case 421:
				dropItem = 3609;
				break;
			case 422:
				dropItem = 3610;
				break;
			case 498:
				dropItem = 4139;
				break;
			case 424:
				dropItem = 3616;
				break;
			case 445:
				dropItem = 3725;
				break;
			case 429:
				dropItem = 3629;
				break;
			case 272:
				dropItem = 1344;
				break;
			case 273:
				dropItem = 2119;
				break;
			case 274:
				dropItem = 2120;
				break;
			case 618:
				dropItem = 4962;
				break;
			case 460:
				dropItem = 3756;
				break;
			case 541:
				dropItem = 4392;
				break;
			case 472:
				dropItem = 3951;
				break;
			case 473:
				dropItem = 3953;
				break;
			case 474:
				dropItem = 3955;
				break;
			case 478:
				dropItem = 4050;
				break;
			case 479:
				dropItem = 4051;
				break;
			case 496:
				dropItem = 4091;
				break;
			case 495:
				dropItem = 4090;
				break;
			case 346:
				dropItem = 2792;
				break;
			case 347:
				dropItem = 2793;
				break;
			case 348:
				dropItem = 2794;
				break;
			case 350:
				dropItem = 2860;
				break;
			case 336:
				dropItem = 2701;
				break;
			case 340:
				dropItem = 2751;
				break;
			case 341:
				dropItem = 2752;
				break;
			case 342:
				dropItem = 2753;
				break;
			case 343:
				dropItem = 2754;
				break;
			case 344:
				dropItem = 2755;
				break;
			case 351:
				dropItem = 2868;
				break;
			case 500:
				dropItem = 4229;
				break;
			case 501:
				dropItem = 4230;
				break;
			case 502:
				dropItem = 4231;
				break;
			case 503:
				dropItem = 4232;
				break;
			case 546:
			case 557:
				dropItem = 4422;
				break;
			case 561:
				dropItem = 4554;
				break;
			case 574:
				dropItem = 4717;
				break;
			case 575:
				dropItem = 4718;
				break;
			case 576:
				dropItem = 4719;
				break;
			case 577:
				dropItem = 4720;
				break;
			case 578:
				dropItem = 4721;
				break;
			case 562:
				dropItem = 4564;
				break;
			case 571:
				dropItem = 4564;
				dropItemStack = WorldGen.genRand.Next(1, 3);
				break;
			case 563:
				dropItem = 4547;
				break;
			case 251:
				dropItem = 1725;
				break;
			case 252:
				dropItem = 1727;
				break;
			case 253:
				dropItem = 1729;
				break;
			case 325:
				dropItem = 2692;
				break;
			case 370:
				dropItem = 3100;
				break;
			case 396:
				dropItem = 3271;
				break;
			case 400:
				dropItem = 3276;
				break;
			case 401:
				dropItem = 3277;
				break;
			case 403:
				dropItem = 3339;
				break;
			case 397:
				dropItem = 3272;
				break;
			case 398:
				dropItem = 3274;
				break;
			case 399:
				dropItem = 3275;
				break;
			case 402:
				dropItem = 3338;
				break;
			case 404:
				dropItem = 3347;
				break;
			case 407:
				dropItem = 3380;
				break;
			case 579:
				dropItem = 4761;
				break;
			case 593:
				dropItem = 4868;
				break;
			case 170:
				dropItem = 1872;
				break;
			case 284:
				dropItem = 2173;
				break;
			case 214:
				dropItem = 85;
				break;
			case 213:
				dropItem = 965;
				break;
			case 211:
				dropItem = 947;
				break;
			case 6:
				dropItem = 11;
				break;
			case 7:
				dropItem = 12;
				break;
			case 8:
				dropItem = 13;
				break;
			case 9:
				dropItem = 14;
				break;
			case 202:
				dropItem = 824;
				break;
			case 234:
				dropItem = 1246;
				break;
			case 226:
				dropItem = 1101;
				break;
			case 224:
				dropItem = 1103;
				break;
			case 36:
				dropItem = 1869;
				break;
			case 311:
				dropItem = 2260;
				break;
			case 312:
				dropItem = 2261;
				break;
			case 313:
				dropItem = 2262;
				break;
			case 229:
				dropItem = 1125;
				break;
			case 230:
				dropItem = 1127;
				break;
			case 221:
				dropItem = 1104;
				break;
			case 222:
				dropItem = 1105;
				break;
			case 223:
				dropItem = 1106;
				break;
			case 248:
				dropItem = 1589;
				break;
			case 249:
				dropItem = 1591;
				break;
			case 250:
				dropItem = 1593;
				break;
			case 191:
				dropItem = 9;
				break;
			case 203:
				dropItem = 836;
				break;
			case 204:
				dropItem = 880;
				break;
			case 166:
				dropItem = 699;
				break;
			case 167:
				dropItem = 700;
				break;
			case 168:
				dropItem = 701;
				break;
			case 169:
				dropItem = 702;
				break;
			case 123:
				dropItem = 424;
				break;
			case 124:
				dropItem = 480;
				break;
			case 157:
				dropItem = 619;
				break;
			case 158:
				dropItem = 620;
				break;
			case 159:
				dropItem = 621;
				break;
			case 161:
				dropItem = 664;
				break;
			case 206:
				dropItem = 883;
				break;
			case 232:
				dropItem = 1150;
				break;
			case 198:
				dropItem = 775;
				break;
			case 314:
				dropItem = Minecart.GetTrackItem(tileCache);
				break;
			case 189:
				dropItem = 751;
				break;
			case 195:
				dropItem = 763;
				break;
			case 194:
				dropItem = 154;
				break;
			case 193:
				dropItem = 762;
				break;
			case 196:
				dropItem = 765;
				break;
			case 197:
				dropItem = 767;
				break;
			case 22:
				dropItem = 56;
				break;
			case 140:
				dropItem = 577;
				break;
			case 23:
				dropItem = 2;
				break;
			case 25:
				dropItem = 61;
				break;
			case 30:
				dropItem = 9;
				break;
			case 208:
				dropItem = 911;
				break;
			case 372:
				dropItem = 3117;
				break;
			case 371:
				dropItem = 3113;
				break;
			case 174:
				dropItem = 713;
				break;
			case 37:
				dropItem = 116;
				break;
			case 38:
				dropItem = 129;
				break;
			case 39:
				dropItem = 131;
				break;
			case 40:
				dropItem = 133;
				break;
			case 41:
				dropItem = 134;
				break;
			case 43:
				dropItem = 137;
				break;
			case 44:
				dropItem = 139;
				break;
			case 45:
				dropItem = 141;
				break;
			case 46:
				dropItem = 143;
				break;
			case 47:
				dropItem = 145;
				break;
			case 48:
				dropItem = 147;
				break;
			case 49:
				dropItem = 148;
				break;
			case 51:
				dropItem = 150;
				break;
			case 53:
				dropItem = 169;
				break;
			case 151:
				dropItem = 607;
				break;
			case 152:
				dropItem = 609;
				break;
			case 56:
				dropItem = 173;
				break;
			case 57:
				dropItem = 172;
				break;
			case 58:
				dropItem = 174;
				break;
			case 70:
				dropItem = 176;
				break;
			case 75:
				dropItem = 192;
				break;
			case 76:
				dropItem = 214;
				break;
			case 78:
				dropItem = 222;
				break;
			case 81:
				dropItem = 275;
				break;
			case 80:
				dropItem = 276;
				break;
			case 188:
				dropItem = 276;
				break;
			case 107:
				dropItem = 364;
				break;
			case 108:
				dropItem = 365;
				break;
			case 111:
				dropItem = 366;
				break;
			case 150:
				dropItem = 604;
				break;
			case 112:
				dropItem = 370;
				break;
			case 116:
				dropItem = 408;
				break;
			case 117:
				dropItem = 409;
				break;
			case 118:
				dropItem = 412;
				break;
			case 119:
				dropItem = 413;
				break;
			case 120:
				dropItem = 414;
				break;
			case 121:
				dropItem = 415;
				break;
			case 122:
				dropItem = 416;
				break;
			case 136:
				dropItem = 538;
				break;
			case 385:
				dropItem = 3234;
				break;
			case 141:
				dropItem = 580;
				break;
			case 145:
				dropItem = 586;
				break;
			case 146:
				dropItem = 591;
				break;
			case 147:
				dropItem = 593;
				break;
			case 148:
				dropItem = 594;
				break;
			case 153:
				dropItem = 611;
				break;
			case 154:
				dropItem = 612;
				break;
			case 155:
				dropItem = 613;
				break;
			case 156:
				dropItem = 614;
				break;
			case 160:
				dropItem = 662;
				break;
			case 175:
				dropItem = 717;
				break;
			case 176:
				dropItem = 718;
				break;
			case 177:
				dropItem = 719;
				break;
			case 163:
				dropItem = 833;
				break;
			case 164:
				dropItem = 834;
				break;
			case 200:
				dropItem = 835;
				break;
			case 210:
				dropItem = 937;
				break;
			case 130:
				dropItem = 511;
				break;
			case 131:
				dropItem = 512;
				break;
			case 321:
				dropItem = 2503;
				break;
			case 322:
				dropItem = 2504;
				break;
			case 54:
				dropItem = 170;
				break;
			case 326:
				dropItem = 2693;
				break;
			case 327:
				dropItem = 2694;
				break;
			case 458:
				dropItem = 3754;
				break;
			case 459:
				dropItem = 3755;
				break;
			case 345:
				dropItem = 2787;
				break;
			case 328:
				dropItem = 2695;
				break;
			case 329:
				dropItem = 2697;
				break;
			case 507:
				dropItem = 4277;
				break;
			case 508:
				dropItem = 4278;
				break;
			case 255:
			case 256:
			case 257:
			case 258:
			case 259:
			case 260:
			case 261:
				dropItem = 1970 + tileCache.TileType - 255;
				break;
			case 262:
			case 263:
			case 264:
			case 265:
			case 266:
			case 267:
			case 268:
				dropItem = 1970 + tileCache.TileType - 262;
				break;
			case 59:
			case 60:
				dropItem = 176;
				break;
			case 190:
				dropItem = 183;
				break;
			case 63:
			case 64:
			case 65:
			case 66:
			case 67:
			case 68:
				dropItem = tileCache.TileType - 63 + 177;
				break;
			case 566:
				dropItem = 999;
				break;
			case 129:
				if (tileCache.TileFrameX >= 324)
					dropItem = 4988;
				else
					dropItem = 502;
				break;
			case 3:
				if (tileCache.TileFrameX == 144)
					dropItem = 5;
				else
					dropItem = 283;
				break;
			case 519:
				if (tileCache.TileFrameY == 90 && WorldGen.genRand.Next(2) == 0)
					dropItem = 183;
				break;
			case 528:
				if (WorldGen.genRand.Next(2) == 0)
					dropItem = 183;
				break;
			case 110:
				if (tileCache.TileFrameX == 144)
					dropItem = 5;
				break;
			case 24:
				if (tileCache.TileFrameX == 144)
					dropItem = 60;
				break;
			case 201:
				if (tileCache.TileFrameX == 270)
					dropItem = 2887;
				break;
			case 73:
				dropItem = 283;
				break;
			case 52:
			case 62:
			case 382:
				if (Main.rand.Next(2) == 0 && GetPlayerForTile(x, y).cordage)
					dropItem = 2996;
				break;
			case 227:
				tileFrameY = tileCache.TileFrameX / 34;
				dropItem = 1107 + tileFrameY;
				if (tileFrameY >= 8 && tileFrameY <= 11)
					dropItem = 3385 + tileFrameY - 8;
				break;
			case 4:
				tileFrameY = tileCache.TileFrameY / 22;
				switch (tileFrameY)
				{
					case 0:
						dropItem = 8;
						break;
					case 8:
						dropItem = 523;
						break;
					case 9:
						dropItem = 974;
						break;
					case 10:
						dropItem = 1245;
						break;
					case 11:
						dropItem = 1333;
						break;
					case 12:
						dropItem = 2274;
						break;
					case 13:
						dropItem = 3004;
						break;
					case 14:
						dropItem = 3045;
						break;
					case 15:
						dropItem = 3114;
						break;
					case 16:
						dropItem = 4383;
						break;
					case 17:
						dropItem = 4384;
						break;
					case 18:
						dropItem = 4385;
						break;
					case 19:
						dropItem = 4386;
						break;
					case 20:
						dropItem = 4387;
						break;
					case 21:
						dropItem = 4388;
						break;
					default:
						dropItem = 426 + tileFrameY;
						break;
				}
				break;
			case 239:
				tileFrameY = tileCache.TileFrameX / 18;
				if (tileFrameY == 0)
					dropItem = 20;
				if (tileFrameY == 1)
					dropItem = 703;
				if (tileFrameY == 2)
					dropItem = 22;
				if (tileFrameY == 3)
					dropItem = 704;
				if (tileFrameY == 4)
					dropItem = 21;
				if (tileFrameY == 5)
					dropItem = 705;
				if (tileFrameY == 6)
					dropItem = 19;
				if (tileFrameY == 7)
					dropItem = 706;
				if (tileFrameY == 8)
					dropItem = 57;
				if (tileFrameY == 9)
					dropItem = 117;
				if (tileFrameY == 10)
					dropItem = 175;
				if (tileFrameY == 11)
					dropItem = 381;
				if (tileFrameY == 12)
					dropItem = 1184;
				if (tileFrameY == 13)
					dropItem = 382;
				if (tileFrameY == 14)
					dropItem = 1191;
				if (tileFrameY == 15)
					dropItem = 391;
				if (tileFrameY == 16)
					dropItem = 1198;
				if (tileFrameY == 17)
					dropItem = 1006;
				if (tileFrameY == 18)
					dropItem = 1225;
				if (tileFrameY == 19)
					dropItem = 1257;
				if (tileFrameY == 20)
					dropItem = 1552;
				if (tileFrameY == 21)
					dropItem = 3261;
				if (tileFrameY == 22)
					dropItem = 3467;
				break;
			case 380:
				tileFrameY = tileCache.TileFrameY / 18;
				dropItem = 3215 + tileFrameY;
				break;
			case 5:
			case 596:
			case 616:
				{
					bool bonusWood = false;
					KillTile_GetTreeDrops(x, y, tileCache, ref bonusWood, ref dropItem, ref secondaryItem);
					if (bonusWood)
						dropItemStack++;

					break;
				}
			case 323:
				{
					dropItem = 2504;
					if (tileCache.TileFrameX <= 132 && tileCache.TileFrameX >= 88)
						secondaryItem = 27;

					int j;
					for (j = y; !Main.tile[x, j].HasTile || !Main.tileSolid[Main.tile[x, j].TileType]; j++)
					{
					}

					if (Main.tile[x, j].HasTile)
					{
						switch (Main.tile[x, j].TileType)
						{
							case 234:
								dropItem = 911;
								break;
							case 116:
								dropItem = 621;
								break;
							case 112:
								dropItem = 619;
								break;
						}
					}

					break;
				}
			case 171:
				if (tileCache.TileFrameX >= 10)
				{
					WorldGen.dropXmasTree(x, y, 0);
					WorldGen.dropXmasTree(x, y, 1);
					WorldGen.dropXmasTree(x, y, 2);
					WorldGen.dropXmasTree(x, y, 3);
				}
				break;
			case 324:
				switch (tileCache.TileFrameY / 22)
				{
					case 0:
						dropItem = 2625;
						break;
					case 1:
						dropItem = 2626;
						break;
					case 2:
						dropItem = 4072;
						break;
					case 3:
						dropItem = 4073;
						break;
					case 4:
						dropItem = 4071;
						break;
				}
				break;
			case 419:
				switch (tileCache.TileFrameX / 18)
				{
					case 0:
						dropItem = 3602;
						break;
					case 1:
						dropItem = 3618;
						break;
					case 2:
						dropItem = 3663;
						break;
				}
				break;
			case 428:
				switch (tileCache.TileFrameY / 18)
				{
					case 0:
						dropItem = 3630;
						break;
					case 1:
						dropItem = 3632;
						break;
					case 2:
						dropItem = 3631;
						break;
					case 3:
						dropItem = 3626;
						break;
				}
				break;
			case 420:
				switch (tileCache.TileFrameY / 18)
				{
					case 0:
						dropItem = 3603;
						break;
					case 1:
						dropItem = 3604;
						break;
					case 2:
						dropItem = 3605;
						break;
					case 3:
						dropItem = 3606;
						break;
					case 4:
						dropItem = 3607;
						break;
					case 5:
						dropItem = 3608;
						break;
				}
				break;
			case 476:
				dropItem = 4040;
				break;
			case 494:
				dropItem = 4089;
				break;
			case 423:
				switch (tileCache.TileFrameY / 18)
				{
					case 0:
						dropItem = 3613;
						break;
					case 1:
						dropItem = 3614;
						break;
					case 2:
						dropItem = 3615;
						break;
					case 3:
						dropItem = 3726;
						break;
					case 4:
						dropItem = 3727;
						break;
					case 5:
						dropItem = 3728;
						break;
					case 6:
						dropItem = 3729;
						break;
				}
				break;
			case 520:
				dropItem = 4326;
				break;
			case 225:
				dropItem = 1124;
				break;
			case 178:
				switch (tileCache.TileFrameX / 18)
				{
					case 0:
						dropItem = 181;
						break;
					case 1:
						dropItem = 180;
						break;
					case 2:
						dropItem = 177;
						break;
					case 3:
						dropItem = 179;
						break;
					case 4:
						dropItem = 178;
						break;
					case 5:
						dropItem = 182;
						break;
					case 6:
						dropItem = 999;
						break;
				}
				break;
			case 149:
				if (tileCache.TileFrameX == 0 || tileCache.TileFrameX == 54)
					dropItem = 596;
				else if (tileCache.TileFrameX == 18 || tileCache.TileFrameX == 72)
					dropItem = 597;
				else if (tileCache.TileFrameX == 36 || tileCache.TileFrameX == 90)
					dropItem = 598;
				break;
			case 13:
				dropItem = (tileCache.TileFrameX / 18) switch
				{
					1 => ItemID.LesserHealingPotion,
					2 => ItemID.LesserManaPotion,
					3 => ItemID.PinkVase,
					4 => ItemID.Mug,
					5 => ItemID.DynastyCup,
					6 => ItemID.WineGlass,
					7 => ItemID.HoneyCup,
					8 => ItemID.SteampunkCup,
					_ => ItemID.Bottle,
				};
				break;
			case 19:
				tileFrameY = tileCache.TileFrameY / 18;
				switch (tileFrameY)
				{
					case 0:
						dropItem = 94;
						break;
					case 1:
						dropItem = 631;
						break;
					case 2:
						dropItem = 632;
						break;
					case 3:
						dropItem = 633;
						break;
					case 4:
						dropItem = 634;
						break;
					case 5:
						dropItem = 913;
						break;
					case 6:
						dropItem = 1384;
						break;
					case 7:
						dropItem = 1385;
						break;
					case 8:
						dropItem = 1386;
						break;
					case 9:
						dropItem = 1387;
						break;
					case 10:
						dropItem = 1388;
						break;
					case 11:
						dropItem = 1389;
						break;
					case 12:
						dropItem = 1418;
						break;
					case 13:
						dropItem = 1457;
						break;
					case 14:
						dropItem = 1702;
						break;
					case 15:
						dropItem = 1796;
						break;
					case 16:
						dropItem = 1818;
						break;
					case 17:
						dropItem = 2518;
						break;
					case 18:
						dropItem = 2549;
						break;
					case 19:
						dropItem = 2566;
						break;
					case 20:
						dropItem = 2581;
						break;
					case 21:
						dropItem = 2627;
						break;
					case 22:
						dropItem = 2628;
						break;
					case 23:
						dropItem = 2629;
						break;
					case 24:
						dropItem = 2630;
						break;
					case 25:
						dropItem = 2744;
						break;
					case 26:
						dropItem = 2822;
						break;
					case 27:
						dropItem = 3144;
						break;
					case 28:
						dropItem = 3146;
						break;
					case 29:
						dropItem = 3145;
						break;
					case 30:
					case 31:
					case 32:
					case 33:
					case 34:
					case 35:
						dropItem = 3903 + tileFrameY - 30;
						break;
					default:
						switch (tileFrameY)
						{
							case 36:
								dropItem = 3945;
								break;
							case 37:
								dropItem = 3957;
								break;
							case 38:
								dropItem = 4159;
								break;
							case 39:
								dropItem = 4180;
								break;
							case 40:
								dropItem = 4201;
								break;
							case 41:
								dropItem = 4222;
								break;
							case 42:
								dropItem = 4311;
								break;
							case 43:
								dropItem = 4416;
								break;
							case 44:
								dropItem = 4580;
								break;
						}
						break;
				}
				break;
			case 33:
				tileFrameY = tileCache.TileFrameY / 22;
				dropItem = 105;
				switch (tileFrameY)
				{
					case 1:
						dropItem = 1405;
						break;
					case 2:
						dropItem = 1406;
						break;
					case 3:
						dropItem = 1407;
						break;
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
						dropItem = 2045 + tileFrameY - 4;
						break;
					default:
						if (tileFrameY >= 14 && tileFrameY <= 16)
						{
							dropItem = 2153 + tileFrameY - 14;
							break;
						}
						switch (tileFrameY)
						{
							case 17:
								dropItem = 2236;
								break;
							case 18:
								dropItem = 2523;
								break;
							case 19:
								dropItem = 2542;
								break;
							case 20:
								dropItem = 2556;
								break;
							case 21:
								dropItem = 2571;
								break;
							case 22:
								dropItem = 2648;
								break;
							case 23:
								dropItem = 2649;
								break;
							case 24:
								dropItem = 2650;
								break;
							case 25:
								dropItem = 2651;
								break;
							case 26:
								dropItem = 2818;
								break;
							case 27:
								dropItem = 3171;
								break;
							case 28:
								dropItem = 3173;
								break;
							case 29:
								dropItem = 3172;
								break;
							case 30:
								dropItem = 3890;
								break;
							case 31:
								dropItem = 3936;
								break;
							case 32:
								dropItem = 3962;
								break;
							case 33:
								dropItem = 4150;
								break;
							case 34:
								dropItem = 4171;
								break;
							case 35:
								dropItem = 4192;
								break;
							case 36:
								dropItem = 4213;
								break;
							case 37:
								dropItem = 4303;
								break;
							case 38:
								dropItem = 4571;
								break;
						}
						break;
				}
				break;
			case 137:
				tileFrameY = tileCache.TileFrameY / 18;
				if (tileFrameY == 0)
					dropItem = 539;
				if (tileFrameY == 1)
					dropItem = 1146;
				if (tileFrameY == 2)
					dropItem = 1147;
				if (tileFrameY == 3)
					dropItem = 1148;
				if (tileFrameY == 4)
					dropItem = 1149;
				break;
			case 135:
				tileFrameY = tileCache.TileFrameY / 18;
				if (tileFrameY == 0)
					dropItem = 529;
				if (tileFrameY == 1)
					dropItem = 541;
				if (tileFrameY == 2)
					dropItem = 542;
				if (tileFrameY == 3)
					dropItem = 543;
				if (tileFrameY == 4)
					dropItem = 852;
				if (tileFrameY == 5)
					dropItem = 853;
				if (tileFrameY == 6)
					dropItem = 1151;
				break;
			case 144:
				if (tileCache.TileFrameX == 0)
					dropItem = 583;
				if (tileCache.TileFrameX == 18)
					dropItem = 584;
				if (tileCache.TileFrameX == 36)
					dropItem = 585;
				if (tileCache.TileFrameX == 54)
					dropItem = 4484;
				if (tileCache.TileFrameX == 72)
					dropItem = 4485;
				break;
			case 61:
			case 74:
				if (tileCache.TileFrameX == 144 && tileCache.TileType == 61)
				{
					dropItem = 331;
					dropItemStack = Main.rand.Next(2, 4);
				}
				else if (tileCache.TileFrameX == 162 && tileCache.TileType == 61)
				{
					dropItem = 223;
				}
				else if (tileCache.TileFrameX >= 108 && tileCache.TileFrameX <= 126 && tileCache.TileType == 61 && Main.rand.Next(20) == 0)
				{
					dropItem = 208;
				}
				else if (Main.rand.Next(100) == 0)
				{
					dropItem = 195;
				}
				break;
			case 71:
			case 72:
				if (Main.rand.Next(40) == 0)
					dropItem = 194;
				else if (Main.rand.Next(2) == 0)
					dropItem = 183;
				break;
			case 50:
				if (tileCache.TileFrameX == 90)
					dropItem = 165;
				else
					dropItem = 149;
				break;
			case 83:
			case 84:
				{
					tileFrameY = tileCache.TileFrameX / 18;
					dropItem = 313 + tileFrameY;
					int num2 = 307 + tileFrameY;
					if (tileFrameY == 6)
					{
						dropItem = 2358;
						num2 = 2357;
					}

					bool flag = WorldGen.IsHarvestableHerbWithSeed(tileCache.TileType, tileFrameY);
					if (GetPlayerForTile(x, y).HeldItem.type == ItemID.StaffofRegrowth)
					{
						dropItemStack = Main.rand.Next(1, 3);
						secondaryItem = num2;
						secondaryItemStack = Main.rand.Next(1, 6);
					}
					else if (flag)
					{
						secondaryItem = num2;
						secondaryItemStack = Main.rand.Next(1, 4);
					}

					break;
				}
			case 589:
				SetGemTreeDrops(999, 4857, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 584:
				SetGemTreeDrops(181, 4852, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 583:
				SetGemTreeDrops(180, 4851, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 586:
				SetGemTreeDrops(179, 4854, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 585:
				SetGemTreeDrops(177, 4853, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 587:
				SetGemTreeDrops(178, 4855, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
			case 588:
				SetGemTreeDrops(182, 4856, tileCache, ref dropItem, ref secondaryItem);
				if (dropItem == 3)
					dropItemStack = Main.rand.Next(1, 3);
				break;
		}
	}

	private static void KillTile_GetTreeDrops(int i, int j, Tile tileCache, ref bool bonusWood, ref int dropItem, ref int secondaryItem)
	{
		if (tileCache.TileFrameX >= 22 && tileCache.TileFrameY >= 198)
		{
			if (Main.netMode != NetmodeID.MultiplayerClient)
			{
				if (WorldGen.genRand.Next(2) == 0)
				{
					int k;
					for (k = j; (!Main.tile[i, k].HasTile || !Main.tileSolid[Main.tile[i, k].TileType] || Main.tileSolidTop[Main.tile[i, k].TileType]); k++)
					{
					}

					Tile tile = Main.tile[i, k];
					if (tile.TileType == 2 || tile.TileType == 109 || tile.TileType == 477 || tile.TileType == 492 || tile.TileType == 147 || tile.TileType == 199 || tile.TileType == 23 || TileLoader.CanDropAcorn(tile.TileType))
					{
						secondaryItem = 27;
					}
				}

				dropItem = 9;
			}
		}
		else
		{
			dropItem = 9;
		}

		if (dropItem != 9)
			return;

		GetTreeBottom(i, j, out int x, out int y);
		if (Main.tile[x, y].HasTile)
		{
			switch (Main.tile[x, y].TileType)
			{
				case 23:
					dropItem = 619;
					break;
				case 60:
					dropItem = 620;
					break;
				case 109:
				case 492:
					dropItem = 621;
					break;
				case 199:
					dropItem = 911;
					break;
				case 70:
					if (WorldGen.genRand.Next(2) == 0)
						dropItem = 183;
					else
						dropItem = 0;
					break;
				case 147:
					dropItem = 2503;
					break;
			}
			TileLoader.DropTreeWood(Main.tile[x, y].TileType, ref dropItem);
			TileLoader.DropPalmTreeWood(Main.tile[x, y].TileType, ref dropItem);
		}

		int num = Player.FindClosest(new Vector2(x * 16, y * 16), 16, 16);
		int axe = Main.player[num].inventory[Main.player[num].selectedItem].axe;
		if (WorldGen.genRand.Next(100) < axe || Main.rand.Next(3) == 0)
			bonusWood = true;
	}

	private static Player GetPlayerForTile(int x, int y) => Main.player[Player.FindClosest(new Vector2(x, y) * 16f, 16, 16)];

	private static void GetTreeBottom(int i, int j, out int x, out int y)
	{
		x = i;
		y = j;
		Tile tileSafely = Framing.GetTileSafely(x, y);
		if (tileSafely.TileType == 323)
		{
			while (y < Main.maxTilesY - 50 && (!tileSafely.HasTile || tileSafely.TileType == 323))
			{
				y++;
				tileSafely = Framing.GetTileSafely(x, y);
			}

			return;
		}

		int num = tileSafely.TileFrameX / 22;
		int num2 = tileSafely.TileFrameY / 22;
		if (num == 3 && num2 <= 2)
			x++;
		else if (num == 4 && num2 >= 3 && num2 <= 5)
			x--;
		else if (num == 1 && num2 >= 6 && num2 <= 8)
			x--;
		else if (num == 2 && num2 >= 6 && num2 <= 8)
			x++;
		else if (num == 2 && num2 >= 9)
			x++;
		else if (num == 3 && num2 >= 9)
			x--;

		tileSafely = Framing.GetTileSafely(x, y);
		while (y < Main.maxTilesY - 50 && (!tileSafely.HasTile || TileID.Sets.IsATreeTrunk[tileSafely.TileType] || tileSafely.TileType == 72))
		{
			y++;
			tileSafely = Framing.GetTileSafely(x, y);
		}
	}

	private static int GetChestItemDrop(Tile tile, int TileType)
	{
		int style = tile.TileFrameX / 36;
		if (TileType == 467)
			return Chest.chestItemSpawn2[style];

		return Chest.chestItemSpawn[style];
	}

	private static int GetDresserItemDrop(Tile tile)
	{
		int style = tile.TileFrameX / 54;

		if (style >= 1 && style <= 3)
			return 646 + style;

		switch (style)
		{
			case 4:
				return 918;
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
				return 2386 + style - 5;
			default:
				return style switch
				{
					16 => 2529,
					17 => 2545,
					18 => 2562,
					19 => 2577,
					20 => 2637,
					21 => 2638,
					22 => 2639,
					23 => 2640,
					24 => 2816,
					25 => 3132,
					26 => 3134,
					27 => 3133,
					28 => 3911,
					29 => 3912,
					30 => 3913,
					31 => 3914,
					32 => 3934,
					33 => 3968,
					34 => 4148,
					35 => 4169,
					36 => 4190,
					37 => 4211,
					38 => 4301,
					39 => 4569,
					_ => 334,
				};
		}
	}

	private static void SetGemTreeDrops(int gemType, int seedType, Tile tileCache, ref int dropItem, ref int secondaryItem)
	{
		if (Main.rand.Next(10) == 0)
			dropItem = gemType;
		else
			dropItem = 3;

		if (tileCache.TileFrameX >= 22 && tileCache.TileFrameY >= 198 && Main.rand.Next(2) == 0)
			secondaryItem = seedType;
	}
}
