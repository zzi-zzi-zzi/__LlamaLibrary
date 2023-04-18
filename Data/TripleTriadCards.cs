﻿using System.Collections.Generic;
using System.Linq;
using ff14bot.Managers;
using LlamaLibrary.Helpers;

namespace LlamaLibrary.Data;

public static class TripleTriadCards
{
    public static List<TripleTriadCardStore> Cards { get; } = CardData.Cards;

    public static TripleTriadCardStore GetCardById(uint id)
    {
        return Cards.Find(x => x.Id == id);
    }

    public static TripleTriadCardStore GetCardByName(string name)
    {
        return Cards.Find(x => x.Name == name);
    }

    public static TripleTriadCardStore GetCardByItemID(uint id)
    {
        return Cards.Find(x => x.ItemId == id);
    }
}

public record TripleTriadCardStore
{
    public TripleTriadCardStore()
    {
    }

    public TripleTriadCardStore(int id, string name, uint itemId)
    {
        Id = id;
        Name = name;
        ItemId = itemId;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public uint ItemId { get; set; }
    public string ItemName => DataManager.GetItem(ItemId).CurrentLocaleName;

    public bool IsUnlocked => UIState.CardUnlocked(Id);

    public bool HaveItem => InventoryManager.FilledSlots.Any(i => i.RawItemId == ItemId);

    public override string ToString()
    {
        return $"{Id} - {Name} - {ItemName}({ItemId})";
    }
}

public static class CardData
{
    internal static readonly List<TripleTriadCardStore> Cards = new List<TripleTriadCardStore>()
    {
        new(1, "Dodo", 9772),
        new(2, "Tonberry", 9773),
        new(3, "Sabotender", 9774),
        new(4, "Spriggan", 9775),
        new(5, "Pudding", 9776),
        new(6, "Bomb", 9777),
        new(7, "Mandragora", 9778),
        new(8, "Coblyn", 9779),
        new(9, "Morbol", 9780),
        new(10, "Coeurl", 9781),
        new(11, "Ahriman", 9782),
        new(12, "Goobbue", 9783),
        new(13, "Chocobo", 9784),
        new(14, "Amalj'aa", 9785),
        new(15, "Ixal", 9786),
        new(16, "Sylph", 9787),
        new(17, "Kobold", 9788),
        new(18, "Sahagin", 9789),
        new(19, "Tataru Taru", 9790),
        new(20, "Moogle", 9791),
        new(21, "Siren", 9792),
        new(22, "Ultros & Typhon", 9793),
        new(23, "Demon Wall", 9794),
        new(24, "Succubus", 9795),
        new(25, "Chimera", 9796),
        new(26, "Blue Dragon", 9797),
        new(27, "Scarface Bugaal Ja", 9798),
        new(28, "Momodi Modi", 9799),
        new(29, "Baderon Tenfingers", 9800),
        new(30, "Mother Miounne", 9801),
        new(31, "Livia sas Junius", 9802),
        new(32, "Rhitahtyn sas Arvina", 9803),
        new(33, "Biggs & Wedge", 9804),
        new(34, "Gerolt", 9805),
        new(35, "Frixio", 9806),
        new(36, "Mutamix Bubblypots", 9807),
        new(37, "Memeroon", 9808),
        new(38, "Behemoth", 9809),
        new(39, "Gilgamesh & Enkidu", 9810),
        new(40, "Ifrit", 9811),
        new(41, "Titan", 9812),
        new(42, "Garuda", 9813),
        new(43, "Good King Moggle Mog XII", 9814),
        new(44, "Raya-O-Senna & A-Ruhn-Senna", 9815),
        new(45, "Godbert Manderville", 9816),
        new(46, "Thancred", 9817),
        new(47, "Nero tol Scaeva", 9818),
        new(48, "Papalymo & Yda", 9819),
        new(49, "Y'shtola", 9820),
        new(50, "Urianger", 9821),
        new(51, "Ultima Weapon", 9822),
        new(52, "Odin", 9823),
        new(53, "Ramuh", 9824),
        new(54, "Leviathan", 9825),
        new(55, "Shiva", 9826),
        new(56, "Minfilia", 9827),
        new(57, "Lahabrea", 9828),
        new(58, "Cid Garlond", 9829),
        new(59, "Alphinaud & Alisaie", 9830),
        new(60, "Louisoix Leveilleur", 9831),
        new(61, "Bahamut", 9832),
        new(62, "Hildibrand & Nashu Mhakaracca", 9833),
        new(63, "Nanamo Ul Namo", 9834),
        new(64, "Gaius van Baelsar", 9835),
        new(65, "Merlwyb Bloefhiswyn", 9836),
        new(66, "Kan-E-Senna", 9837),
        new(67, "Raubahn Aldynn", 9838),
        new(68, "Warrior of Light", 9839),
        new(69, "Firion", 9840),
        new(70, "Onion Knight", 9841),
        new(71, "Cecil Harvey", 9842),
        new(72, "Bartz Klauser", 9843),
        new(73, "Terra Branford", 9844),
        new(74, "Cloud Strife", 9845),
        new(75, "Squall Leonhart", 9846),
        new(76, "Zidane Tribal", 9847),
        new(77, "Tidus", 9848),
        new(78, "Shantotto", 9849),
        new(79, "Vaan", 9850),
        new(80, "Lightning", 9851),
        new(86, "Griffin", 12260),
        new(87, "Tioman", 12261),
        new(89, "Lucia goe Junius", 12262),
        new(84, "Yugiri Mistwalker", 12263),
        new(88, "Estinien", 12264),
        new(96, "Aymeric", 12265),
        new(100, "Midgardsormr", 12266),
        new(82, "Vanu Vanu", 12267),
        new(83, "Gnath", 12268),
        new(81, "Gaelicat", 12269),
        new(92, "Matoya", 12270),
        new(99, "Nidhogg", 12271),
        new(90, "Ysayle", 12272),
        new(85, "Fat Chocobo", 12273),
        new(97, "Ravana", 12274),
        new(98, "Bismarck", 12275),
        new(93, "Count Edmont de Fortemps", 12276),
        new(95, "Haurchefant", 12277),
        new(91, "Hilda", 12278),
        new(94, "Byblos", 12279),
        new(101, "Deepeye", 13360),
        new(102, "Archaeornis", 13361),
        new(103, "Paissa", 13362),
        new(104, "Dhalmel", 13363),
        new(105, "Bandersnatch", 13364),
        new(106, "Crawler", 13365),
        new(107, "Poroggo", 13366),
        new(108, "Vedrfolnir", 13367),
        new(109, "Coeurlregina", 13368),
        new(110, "Progenitrix", 13369),
        new(111, "Belladonna", 13370),
        new(112, "Echidna", 13371),
        new(113, "Pipin Tarupin", 13372),
        new(114, "Julyan Manderville", 13373),
        new(115, "Moglin", 13374),
        new(116, "Charibert", 13375),
        new(117, "Roundrox", 13376),
        new(118, "Senor Sabotender", 13377),
        new(119, "Regula van Hydrus", 13378),
        new(120, "Archbishop Thordan VII", 13379),
        new(121, "Honoroit", 14191),
        new(122, "Hoary Boulder & Coultenet", 14192),
        new(123, "Brachiosaur", 14193),
        new(124, "Darkscale", 14194),
        new(125, "Fenrir", 14195),
        new(126, "Kraken", 14196),
        new(127, "Vicegerent to the Warden", 14197),
        new(128, "Manxome Molaa Ja Ja", 14198),
        new(129, "Ferdiad", 14199),
        new(130, "Calcabrina", 14200),
        new(131, "Kuribu", 14201),
        new(132, "Phlegethon", 14202),
        new(133, "Artoirel de Fortemps", 14203),
        new(134, "Emmanellain de Fortemps", 14204),
        new(135, "Xande", 14205),
        new(136, "Brute Justice", 14206),
        new(137, "Sephirot", 14207),
        new(138, "F'lhaminn", 14208),
        new(139, "Vidofnir", 14209),
        new(140, "Cloud of Darkness", 14210),
        new(141, "Lolorito Nanarito", 15615),
        new(142, "Gibrillont", 15616),
        new(143, "Laniaitte de Haillenarte", 15617),
        new(144, "Rhoswen", 15618),
        new(145, "Carvallain de Gorgagne", 15619),
        new(146, "Kal Myhk", 15620),
        new(147, "Waukkeon", 15621),
        new(148, "Curator", 15622),
        new(149, "Mistbeard", 15623),
        new(150, "Unei & Doga", 15624),
        new(151, "Tiamat", 15625),
        new(152, "Calofisteri", 15871),
        new(153, "Hraesvelgr", 15872),
        new(154, "Apkallu", 16757),
        new(155, "Colibri", 16758),
        new(156, "Magitek Death Claw", 16759),
        new(157, "Liquid Flame", 16760),
        new(158, "Lost Lamb", 16761),
        new(159, "Delivery Moogle", 16762),
        new(160, "Magitek Colossus", 16763),
        new(161, "Strix", 16764),
        new(162, "Tozol Huatotl", 16765),
        new(163, "Alexander Prime", 16766),
        new(164, "Brendt, Brennan, & Bremondt", 16767),
        new(165, "Heavensward Thancred", 16768),
        new(166, "Heavensward Y'shtola", 16769),
        new(167, "Nael van Darnus", 16770),
        new(168, "Sophia", 16771),
        new(169, "Opo-opo", 16772),
        new(170, "Adamantoise", 16773),
        new(171, "Magitek Vanguard", 16774),
        new(172, "Magitek Gunship", 16775),
        new(173, "Gold Saucer Attendant", 16776),
        new(174, "Lava Scorpion", 17680),
        new(175, "Magitek Predator", 17681),
        new(176, "Magitek Sky Armor", 17682),
        new(177, "The Griffin", 17683),
        new(178, "Roland", 17684),
        new(179, "Diabolos Hollow", 17685),
        new(180, "Armored Weapon", 17686),
        new(181, "Gigi", 17687),
        new(182, "Zurvan", 17688),
        new(183, "Namazu", 20240),
        new(184, "Kojin", 20241),
        new(185, "Ananta", 20242),
        new(186, "M'naago", 20243),
        new(187, "Kotokaze", 20244),
        new(188, "Mammoth", 20245),
        new(189, "Phoebad", 20246),
        new(190, "Susano", 20247),
        new(191, "Lakshmi", 20248),
        new(192, "Grynewaht", 20249),
        new(193, "Rasho", 20250),
        new(194, "Cirina", 20251),
        new(195, "Magnai", 20252),
        new(196, "Sadu", 20253),
        new(197, "Shinryu", 20254),
        new(198, "Yotsuyu", 20255),
        new(199, "Krile", 20256),
        new(200, "Lyse", 20257),
        new(201, "Zenos yae Galvus", 20258),
        new(202, "Hien", 20259),
        new(203, "Mossling", 21181),
        new(204, "Chapuli", 21182),
        new(205, "Qiqirn Meateater", 21183),
        new(206, "Hrodric Poisontongue", 21184),
        new(207, "Fordola rem Lupis", 21185),
        new(208, "Rofocale", 21186),
        new(209, "Argath Thadalfus", 21187),
        new(210, "Raubahn & Pipin", 21188),
        new(211, "Koja", 21189),
        new(212, "Ango", 21190),
        new(213, "Guidance Node", 22381),
        new(214, "Tansui", 22382),
        new(215, "Genbu", 22383),
        new(216, "Byakko", 22384),
        new(217, "Arenvald Lentinus", 22385),
        new(218, "Lupin", 22386),
        new(219, "Hancock", 22387),
        new(220, "Hisui & Kurenai", 22388),
        new(221, "Wanyudo & Katasharin", 23044),
        new(222, "Hatamoto", 23045),
        new(223, "Yukinko", 23046),
        new(224, "Qitian Dasheng", 23047),
        new(225, "Hiruko", 23048),
        new(226, "Happy Bunny", 23049),
        new(227, "Louhi", 23050),
        new(228, "Tsukuyomi", 23051),
        new(229, "Yiazmat", 23052),
        new(230, "Gosetsu", 23053),
        new(231, "Karakuri Hanya", 23907),
        new(232, "Muud Suud", 23908),
        new(233, "Tokkapchi", 23909),
        new(234, "Mist Dragon", 23910),
        new(235, "Suzaku", 23911),
        new(236, "Pazuzu", 23912),
        new(237, "Penthesilea", 23913),
        new(238, "Asahi sas Brutus", 23914),
        new(239, "Yojimbo & Daigoro", 23915),
        new(240, "Omega", 23916),
        new(241, "Stormblood Tataru Taru", 24869),
        new(242, "Dvergr", 24870),
        new(243, "Ejika Tsunjika", 24871),
        new(244, "Prometheus", 24872),
        new(245, "Provenance Watcher", 24873),
        new(246, "Seiryu", 24874),
        new(247, "Alpha", 24875),
        new(248, "Great Gold Whisker", 24876),
        new(249, "Stormblood Gilgamesh", 24877),
        new(250, "Ultima, the High Seraph", 24878),
        new(251, "Stormblood Alphinaud & Alisaie", 24879),
        new(252, "Noctis Lucis Caelum", 24880),
        new(253, "Amaro", 26758),
        new(254, "Evil Weapon", 26759),
        new(255, "Lord and Lady Chai", 26760),
        new(256, "Gigantender", 26761),
        new(257, "Feo Ul", 26762),
        new(258, "Runar", 26763),
        new(259, "Grenoldt", 26764),
        new(260, "Philia", 26765),
        new(261, "Titania", 26766),
        new(262, "Eros", 26767),
        new(263, "Storge", 26768),
        new(264, "Formidable", 26769),
        new(265, "Lyna", 26770),
        new(266, "Jongleurs of Eulmore", 26771),
        new(267, "Innocence", 26772),
        new(268, "Shadowbringers Y'shtola", 26773),
        new(269, "Shadowbringers Urianger", 26774),
        new(270, "Ran'jit", 26775),
        new(271, "Hades", 26776),
        new(272, "Ardbert", 26777),
        new(273, "Hobgoblin", 28653),
        new(274, "Porxie", 28654),
        new(275, "Iguana", 28655),
        new(276, "Nu Mou", 28656),
        new(277, "Fuath", 28657),
        new(278, "Leannan Sith", 28658),
        new(279, "Seeker of Solitude", 28659),
        new(280, "Oracle of Light", 28660),
        new(281, "Archaeotania", 28661),
        new(282, "9S", 28662),
        new(283, "Flower Basket", 29704),
        new(284, "Qitari", 29705),
        new(285, "Gnoll", 29706),
        new(286, "Lizbeth", 29707),
        new(287, "Batsquatch", 29708),
        new(288, "Forgiven Obscenity", 29709),
        new(289, "Huaca", 29710),
        new(290, "Unknown", 29711),
        new(291, "Ruby Weapon", 29712),
        new(292, "Therion", 29713),
        new(293, "Varis yae Galvus", 29993),
        new(294, "Dwarf", 31340),
        new(295, "Ehll Tou", 31341),
        new(296, "Rolling Tankard", 31342),
        new(297, "Lugus", 31343),
        new(298, "Dawon", 31344),
        new(299, "Adrammelech", 31345),
        new(300, "Elidibus", 31346),
        new(301, "Shadowbringers Thancred", 31347),
        new(302, "Sapphire Weapon", 31348),
        new(303, "2P", 31349),
        new(304, "Shadowbringers Warrior of Light", 31350),
        new(305, "Great Azuro", 33014),
        new(306, "Mother Porxie", 33015),
        new(307, "Trinity Seeker", 33016),
        new(308, "Trinity Avowed", 33017),
        new(309, "Azulmagia", 33018),
        new(310, "Siegfried", 33019),
        new(311, "Gogo, Master of Mimicry", 33020),
        new(312, "Emerald Weapon", 33021),
        new(313, "Ryne", 33022),
        new(314, "Gaia", 33023),
        new(315, "Eden's Promise", 33024),
        new(316, "Phoenix", 33025),
        new(317, "Keeper of the Keys", 33332),
        new(318, "Lunar Bahamut", 33333),
        new(319, "Valens van Varro", 33334),
        new(320, "Lunar Ifrit", 33335),
        new(321, "4th-make Shemhazai", 33336),
        new(322, "4th-make Cuchulainn", 33337),
        new(323, "G-Warrior", 33338),
        new(324, "Diamond Weapon", 33339),
        new(325, "Diablo Armament", 33340),
        new(326, "2B", 33341),
        new(327, "Troll", 36265),
        new(328, "Pisaca", 36266),
        new(329, "Ea", 36267),
        new(330, "Arkasodara", 36268),
        new(331, "Loporrit", 36269),
        new(332, "Argos", 36270),
        new(333, "Hermes", 36271),
        new(334, "Amon the Undying", 36272),
        new(335, "Erichthonios", 36273),
        new(336, "Magus Sisters", 36274),
        new(337, "Meteion", 36275),
        new(338, "Fourchenault Leveilleur", 36276),
        new(339, "Anima", 36277),
        new(340, "Quintus van Cinna", 36278),
        new(341, "Endwalker Alphinaud & Alisaie", 36279),
        new(342, "Hythlodaeus", 36280),
        new(343, "Vrtra", 36281),
        new(344, "Zodiark", 36282),
        new(345, "Hydaelyn", 36283),
        new(346, "Zenos Galvus", 36284),
        new(347, "Rampart", 37334),
        new(348, "Hippo Cart", 37335),
        new(349, "Gajasura", 37336),
        new(350, "Rhalgr", 37337),
        new(351, "Azeyma", 37338),
        new(352, "Nald", 37339),
        new(353, "Thal", 37340),
        new(354, "Chi", 37341),
        new(355, "Daivadipa", 37342),
        new(356, "Endsinger", 37343),
        new(357, "N-7000", 38429),
        new(358, "Geryon the Steer", 38430),
        new(359, "Gladiator of Sil'dih", 38431),
        new(360, "Thorne Knight", 38432),
        new(361, "Beatrice", 38433),
        new(362, "Byregot", 38434),
        new(363, "Shadowcaster Zeless Gah", 38435),
        new(364, "Scarmiglione", 38436),
        new(365, "Barbariccia", 38437),
        new(366, "Chief Keyward Lahabrea", 38438),
        new(367, "Hephaistos", 38439),
        new(368, "Clockwork Onmyoji & Clockwork Yojimbo", 39367),
        new(370, "Felicitous Furball", 39369),
        new(371, "Anden", 39370),
        new(374, "Menphina", 39373),
        new(375, "Cagnazzo", 39374),
        new(376, "Rubicante", 39375),
    };
}