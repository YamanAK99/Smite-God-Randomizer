using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smiteRandomizer
{
    /**
     * Use XML file to save arrays
     * add label to tell user where to start and one for role pick
     * use inheritance
     * create a class made of boleans for verification
     */
    public partial class godRandomizer : Form
    {
        List<Gods> godList = new List<Gods>();
        List<Items> itemList = new List<Items>();
        string selectedRole;
        public godRandomizer()
        {
            InitializeComponent();
            roleFilterComboBox.SelectedIndex = 0;
            godPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item1PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item3PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item4PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item5PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            item6PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            godPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            godList.Add(new Gods("Achilles", "images/gods/Achilles.jpg", "Warrior", "Hero Of The Trojan War"));
            godList.Add(new Gods("Agni", "images/gods/Agni.jpg", "Mage", "God Of Fire"));
            godList.Add(new Gods("Ah Muzen Cab", "images/gods/AMC.jpg", "Hunter", "God Of Bees"));
            godList.Add(new Gods("Ah Puch", "images/gods/AhPuch.jpg", "Mage", "Horrific God Of Decay"));
            godList.Add(new Gods("Amaterasu", "images/gods/Amaterasu.jpg", "Warrior", "The Shining Light"));
            godList.Add(new Gods("Anhur", "images/gods/Anhur.jpg", "Hunter", "Slayer Of Enemies"));
            godList.Add(new Gods("Anubis", "images/gods/Anubis.jpg", "Mage", "God Of The Dead"));
            godList.Add(new Gods("Ao Kuang", "images/gods/AoKuang.jpg", "Mage", "Dragon King Of The Eastern Seas"));
            godList.Add(new Gods("Aphrodite", "images/gods/Aphrodite.jpg", "Mage", "Goddess Of Beauty"));
            godList.Add(new Gods("Apollo", "images/gods/Apollo.jpg", "Hunter", "God Of Music"));
            godList.Add(new Gods("Arachne", "images/gods/Arachne.jpg", "Assassin", "The Weaver"));
            godList.Add(new Gods("Ares", "images/gods/Ares.jpg", "Guardian", "God Of War"));
            godList.Add(new Gods("Artemis", "images/gods/Artemis.jpg", "Hunter", "Goddess Of The Hunt"));
            godList.Add(new Gods("Artio", "images/gods/Artio.jpg", "Guardian", "The Bear Goddess"));
            godList.Add(new Gods("Athena", "images/gods/Athena.jpg", "Guardian", "Goddess Of Wisdom"));
            godList.Add(new Gods("Awilix", "images/gods/Awilix.jpg", "Assassin", "Goddess Of The Moon"));
            godList.Add(new Gods("Bacchus", "images/gods/Bacchus.jpg", "Guardian", "God Of Wine"));
            godList.Add(new Gods("Bakasura", "images/gods/Bakasura.jpg", "Assassin", "The Great Devourer"));
            godList.Add(new Gods("Baron Samedi", "images/gods/BaronSamedi.jpg", "Mage", "God Of Life And Death"));
            godList.Add(new Gods("Bastet", "images/gods/Bastet.jpg", "Assassin", "Goddess Of Cats"));
            godList.Add(new Gods("Bellona", "images/gods/Bellona.jpg", "Warrior", "Goddess Of War"));
            godList.Add(new Gods("Cabrakan", "images/gods/Cabrakan.jpg", "Guardian", "Destroyer Of Mountains"));
            godList.Add(new Gods("Camazotz", "images/gods/Camazotz.jpg", "Assassin", "Deadly God Of Bats"));
            godList.Add(new Gods("Cerberus", "images/gods/Cerberus.jpg", "Guardian", "Warden Of The Underworld"));
            godList.Add(new Gods("Cernunnos", "images/gods/Cernunnos.jpg", "Hunter", "The Horned God"));
            godList.Add(new Gods("Chaac", "images/gods/Chaac.jpg", "Warrior", "God Of Rain"));
            godList.Add(new Gods("Chang'e", "images/gods/Change.jpg", "Mage", "Faerie Of The Moon"));
            godList.Add(new Gods("Chernobog", "images/gods/Chernobog.jpg", "Hunter", "Lord Of Darkness"));
            godList.Add(new Gods("Chiron", "images/gods/Chiron.jpg", "Hunter", "The Great Teacher"));
            godList.Add(new Gods("Chronos", "images/gods/Chronos.jpg", "Mage", "Keeper Of Time"));
            godList.Add(new Gods("Cu Chulainn", "images/gods/CuChulainn.jpg", "Warrior", "Hound Of Ulster"));
            godList.Add(new Gods("Cupid", "images/gods/Cupid.jpg", "Hunter", "God Of Love"));
            godList.Add(new Gods("Da Ji", "images/gods/DaJi.jpg", "Assassin", "The Nine-Tailed Fox"));
            godList.Add(new Gods("Discordia", "images/gods/Discordia.jpg", "Mage", "Goddess Of Strife"));
            godList.Add(new Gods("Erlang Shen", "images/gods/ErlangShen.jpg", "Warrior", "The Illustrious Sage"));
            godList.Add(new Gods("Fafnir", "images/gods/Fafnir.jpg", "Guardian", "The Lord Of Glittering Gold"));
            godList.Add(new Gods("Fenrir", "images/gods/Fenrir.jpg", "Assassin", "The Unbound"));
            godList.Add(new Gods("Freya", "images/gods/Freya.jpg", "Mage", "Queen Of The Valkyries"));
            godList.Add(new Gods("Ganesha", "images/gods/Ganesha.jpg", "Guardian", "God Of Success"));
            godList.Add(new Gods("Geb", "images/gods/Geb.jpg", "Guardian", "God Of Earth"));
            godList.Add(new Gods("Guan Yu", "images/gods/GuanYu.jpg", "Warrior", "Saint Of War"));
            godList.Add(new Gods("Hachiman", "images/gods/Hachiman.jpg", "Hunter", "Lord Of The Eight Banners"));
            godList.Add(new Gods("Hades", "images/gods/Hades.jpg", "Mage", "King Of The Underworld"));
            godList.Add(new Gods("He Bo", "images/gods/HeBo.jpg", "Mage", "God Of The Yellow River"));
            godList.Add(new Gods("Heimdallr", "images/gods/Heimdallr.jpg", "Hunter", "The Vigilant"));
            godList.Add(new Gods("Hel", "images/gods/Hel.jpg", "Mage", "Goddess Of The Underworld"));
            godList.Add(new Gods("Hera", "images/gods/Hera.jpg", "Mage", "Queen Of The Gods"));
            godList.Add(new Gods("Hercules", "images/gods/Hercules.jpg", "Warrior", "Champion Of Rome"));
            godList.Add(new Gods("Horus", "images/gods/Horus.jpg", "Warrior", "The Rightful Heir"));
            godList.Add(new Gods("Hou Yi", "images/gods/HouYi.jpg", "Hunter", "Defender Of The Earth"));
            godList.Add(new Gods("Hun Batz", "images/gods/HunBatz.jpg", "Assassin", "The Howler Monkey God"));
            godList.Add(new Gods("Isis", "images/gods/Isis.jpg", "Mage", "Goddess Of Magic"));
            godList.Add(new Gods("Izanami", "images/gods/Izanami.jpg", "Hunter", "Matron Of The Dead"));
            godList.Add(new Gods("Janus", "images/gods/Janus.jpg", "Mage", "God Of Portals And Transitions"));
            godList.Add(new Gods("Jine Wei", "images/gods/JingWei.jpg", "Hunter", "The Oathkeeper"));
            godList.Add(new Gods("Jormungandr", "images/gods/Jormungandr.jpg", "Guardian", "The World Serpent"));
            godList.Add(new Gods("Kali", "images/gods/Kali.jpg", "Assassin", "Goddess Of Destruction"));
            godList.Add(new Gods("Khepri", "images/gods/Khepri.jpg", "Guardian", "The Dawn Bringer"));
            godList.Add(new Gods("King Arthur", "images/gods/KingArthur.jpg", "Warrior", "Wielder Of Excalibur"));
            godList.Add(new Gods("Kukulkan", "images/gods/Kukulkan.jpg", "Mage", "Serpent Of The Nine Winds"));
            godList.Add(new Gods("Kumbhakarna", "images/gods/Kumbhakarna.jpg", "Guardian", "The Sleeping Giant"));
            godList.Add(new Gods("Kuzenbo", "images/gods/Kuzenbo.jpg", "Guardian", "King Kappa"));
            godList.Add(new Gods("Loki", "images/gods/Loki.jpg", "Assassin", "The Trickster God"));
            godList.Add(new Gods("Medusa", "images/gods/Medusa.jpg", "Hunter", "The Gorgon"));
            godList.Add(new Gods("Mercury", "images/gods/Mercury.jpg", "Assassin", "Messenger Of The Gods"));
            godList.Add(new Gods("Merlin", "images/gods/Merlin.jpg", "Mage", "The Master Wizard"));
            godList.Add(new Gods("Ne Zha", "images/gods/NeZha.jpg", "Assassin", "The Third Lotus Prince"));
            godList.Add(new Gods("Neith", "images/gods/Neith.jpg", "Hunter", "Weaver Of Fate"));
            godList.Add(new Gods("Nemesis", "images/gods/Nemesis.jpg", "Assassin", "Goddess Of Vengeance"));
            godList.Add(new Gods("Nike", "images/gods/Nike.jpg", "Warrior", "Goddess Of Victory"));
            godList.Add(new Gods("Nox", "images/gods/Nox.jpg", "Mage", "Goddess Of Night"));
            godList.Add(new Gods("Nu Wa", "images/gods/NuWa.jpg", "Mage", "Guardian Of Heaven"));
            godList.Add(new Gods("Odin", "images/gods/Odin.jpg", "Warrior", "The Allfather"));
            godList.Add(new Gods("Olorun", "images/gods/Olorun.jpg", "Mage", "Ruler Of The Heavens"));
            godList.Add(new Gods("Osiris", "images/gods/Osiris.jpg", "Warrior", "Broken God Of The AfterLife"));
            godList.Add(new Gods("Pele", "images/gods/Pele.jpg", "Assassin", "Goddess Of Volcanoes"));
            godList.Add(new Gods("Persephone", "images/gods/Persephone.jpg", "Mage", "Queen Of The Underworld"));
            godList.Add(new Gods("Poseidon", "images/gods/Poseidon.jpg", "Mage", "God Of The Oceans"));
            godList.Add(new Gods("Ra", "images/gods/Ra.jpg", "Mage", "Sun God"));
            godList.Add(new Gods("Raijin", "images/gods/Raijin.jpg", "Mage", "Master Of Thunder"));
            godList.Add(new Gods("Rama", "images/gods/Rama.jpg", "Hunter", "Seventh Avatar Of Vishnu"));
            godList.Add(new Gods("Ratatoskr", "images/gods/Ratatoskr.jpg", "Assassin", "The Sly Messenger"));
            godList.Add(new Gods("Ravana", "images/gods/Ravana.jpg", "Assassin", "Demon King Of Lanka"));
            godList.Add(new Gods("Scylla", "images/gods/Scylla.jpg", "Mage", "Horror Of The Sea"));
            godList.Add(new Gods("Serqet", "images/gods/Serqet.jpg", "Assassin", "Goddess Of Venom"));
            godList.Add(new Gods("Set", "images/gods/Set.jpg", "Assassin", "The Usurper"));
            godList.Add(new Gods("Skadi", "images/gods/Skadi.jpg", "Hunter", "Goddess Of Winter"));
            godList.Add(new Gods("Sobek", "images/gods/Sobek.jpg", "Guardian", "God Of The Nile"));
            godList.Add(new Gods("Sol", "images/gods/Sol.jpg", "Mage", "Goddess Of The Sun"));
            godList.Add(new Gods("Sun Wukong", "images/gods/SunWukong.jpg", "Warrior", "The Monkey King"));
            godList.Add(new Gods("Susano", "images/gods/Susano.jpg", "Assassin", "God Of The Summer Storm"));
            godList.Add(new Gods("Sylvanus", "images/gods/Sylvanus.jpg", "Guardian", "Keeper Of The Wild"));
            godList.Add(new Gods("Terra", "images/gods/Terra.jpg", "Guardian", "The Earth Mother"));
            godList.Add(new Gods("Thanatos", "images/gods/Thanatos.jpg", "Assassin", "Hand Of Death"));
            godList.Add(new Gods("The Morrigan", "images/gods/TheMorrigan.jpg", "Mage", "Phantom Queen"));
            godList.Add(new Gods("Thor", "images/gods/Thor.jpg", "Assassin", "God Of Thunder"));
            godList.Add(new Gods("Thoth", "images/gods/Thoth.jpg", "Mage", "Arbiter Of The Damned"));
            godList.Add(new Gods("Tyr", "images/gods/Tyr.jpg", "Warrior", "The Lawgiver"));
            godList.Add(new Gods("Ullr", "images/gods/Ullr.jpg", "Hunter", "The Glorious One"));
            godList.Add(new Gods("Vamana", "images/gods/Vamana.jpg", "Warrior", "Fifth Avatar Of Vishnu"));
            godList.Add(new Gods("Vulcan", "images/gods/Vulcan.jpg", "Mage", "Smith Of The Gods"));
            godList.Add(new Gods("Xbalanque", "images/gods/Xbalanque.jpg", "Hunter", "Hidden Jaguar Sun"));
            godList.Add(new Gods("Xing Tian", "images/gods/XingTian.jpg", "Guardian", "The Relentless"));
            godList.Add(new Gods("Yemoja", "images/gods/Yemoja.jpg", "Guardian", "Goddess Of Rivers"));
            godList.Add(new Gods("Ymir", "images/gods/Ymir.jpg", "Guardian", "Father Of The Frost Giants"));
            godList.Add(new Gods("Zeus", "images/gods/Zeus.jpg", "Mage", "God Of The Sky"));
            godList.Add(new Gods("Zhong Kui", "images/gods/ZhongKui.jpg", "Mage", "The Demon Queller"));

            itemList.Add(new Items("Sovereignty", "images/items/Sovereignty.jpg", "Global"));
            itemList.Add(new Items("Mystical Mail", "images/items/MysticalMail.jpg", "Global"));
            itemList.Add(new Items("Midgardian Mail", "images/items/MidgardianMail.jpg", "Global"));
            itemList.Add(new Items("Emperor's Armor", "images/items/EmperorsArmor.jpg", "Global"));
            itemList.Add(new Items("The Executioner", "images/items/TheExecutioner.jpg", "Physical"));
            itemList.Add(new Items("Qin's Sais", "images/items/QinsSais.jpg", "Physical"));
            itemList.Add(new Items("Asi", "images/items/Asi.jpg", "Physical"));
            itemList.Add(new Items("Pythagorem's Piece", "images/items/PythagoremsPiece.jpg", "Magical"));
            itemList.Add(new Items("Bancroft's Talon", "images/items/BancroftsTalon.jpg", "Magical"));
            itemList.Add(new Items("Typhon's Fang", "images/items/TyphonsFang.jpg", "Magical"));
            itemList.Add(new Items("Soul Gem", "images/items/SoulGem.jpg", "Magical"));
            itemList.Add(new Items("Titan's Bane", "images/items/TitansBane.jpg", "Physical"));
            itemList.Add(new Items("Brawler's Beat Stick", "images/items/BrawlersBeatStick.jpg", "Physical"));
            itemList.Add(new Items("Jotunn's Wrath", "images/items/JotunnsWrath.jpg", "Physical"));
            itemList.Add(new Items("The Crusher", "images/items/TheCrusher.jpg", "Physical"));
            itemList.Add(new Items("Transcendence", "images/items/Transcendence.jpg", "Physical"));
            itemList.Add(new Items("Hydra's Lament", "images/items/HydrasLament.jpg", "Physical"));
            itemList.Add(new Items("Heartseeker", "images/items/Heartseeker.jpg", "Physical"));
            itemList.Add(new Items("Warrior Tabi", "images/items/WarriorTabi.jpg", "Physical"));
            itemList.Add(new Items("Ninja Tabi", "images/items/NinjaTabi.jpg", "Physical"));
            itemList.Add(new Items("Reinforced Greaves", "images/items/ReinforcedGreaves.jpg", "Physical"));
            itemList.Add(new Items("Talaria Boots", "images/items/TalariaBoots.jpg", "Physical"));
            itemList.Add(new Items("Shoes Of The Magi", "images/items/ShoesOfTheMagi.jpg", "Magical"));
            itemList.Add(new Items("Shoes Of Focus", "images/items/ShoesOfFocus.jpg", "Magical"));
            itemList.Add(new Items("Reinforced Shoes", "images/items/ReinforcedShoes.jpg", "Magical"));
            itemList.Add(new Items("Traveler's Shoes", "images/items/TravelersShoes.jpg", "Magical"));
            itemList.Add(new Items("Deathbringer", "images/items/Deathbringer.jpg", "Physical"));
            itemList.Add(new Items("Rage", "images/items/Rage.jpg", "Physical"));
            itemList.Add(new Items("Malice", "images/items/Malice.jpg", "Physical"));
            itemList.Add(new Items("Soul Eater", "images/items/SoulEater.jpg", "Physical"));
            itemList.Add(new Items("Devourer's Gauntlet", "images/items/DevourersGauntlet.jpg", "Physical"));
            itemList.Add(new Items("Bloodforge", "images/items/Bloodforge.jpg", "Physical"));
            itemList.Add(new Items("Witchblade", "images/items/Witchblade.jpg", "Global"));
            itemList.Add(new Items("Winged Blade", "images/items/WingedBlade.jpg", "Global"));
            itemList.Add(new Items("Relic Dagger", "images/items/RelicDagger.jpg", "Global"));
            itemList.Add(new Items("Toxic Blade", "images/items/ToxicBlade.jpg", "Global"));
            itemList.Add(new Items("Frostbound Hammer", "images/items/FrostboundHammer.jpg", "Physical"));
            itemList.Add(new Items("Runeforged Hammer", "images/items/RuneforgedHammer.jpg", "Physical"));
            itemList.Add(new Items("Blackthorn Hammer", "images/items/BlackthornHammer.jpg", "Physical"));
            itemList.Add(new Items("Shifter's Shield", "images/items/ShiftersShield.jpg", "Physical"));
            itemList.Add(new Items("Void Shield", "images/items/VoidShield.jpg", "Physical"));
            itemList.Add(new Items("Hide Of The Nemean Lion", "images/items/HideOfTheNemeanLion.jpg", "Global"));
            itemList.Add(new Items("Breasplate Of Valor", "images/items/BreastplateOfValor.jpg", "Global"));
            itemList.Add(new Items("Spectral Armor", "images/items/SpectralArmor.jpg", "Global"));
            itemList.Add(new Items("Contagion", "images/items/Contagion.jpg", "Global"));
            itemList.Add(new Items("Magi's Cloak", "images/items/MagisCloak.jpg", "Global"));
            itemList.Add(new Items("Hide Of The Urchin", "images/items/HideOfTheUrchin.jpg", "Global"));
            itemList.Add(new Items("Spirit Robe", "images/items/SpiritRobe.jpg", "Global"));
            itemList.Add(new Items("Mantle Of Dicord", "images/items/MantleOfDiscord.jpg", "Global"));
            itemList.Add(new Items("Bulwark Of Hope", "images/items/BulwarkOfHope.jpg", "Global"));
            itemList.Add(new Items("Pestilence", "images/items/Pestilence.jpg", "Global"));
            itemList.Add(new Items("Heartward Amulet", "images/items/HeartwardAmulet.jpg", "Global"));
            itemList.Add(new Items("Talisman Of Energy", "images/items/TalismanOfEnergy.jpg", "Global"));
            itemList.Add(new Items("Demonic Grip", "images/items/DemonicGrip.jpg", "Magical"));
            itemList.Add(new Items("Telkhines Ring", "images/items/TelkhinesRing.jpg", "Magical"));
            itemList.Add(new Items("Hastened Ring", "images/items/HastenedRing.jpg", "Magical"));
            itemList.Add(new Items("Ring Of Hecate", "images/items/RingOfHecate.jpg", "Magical"));
            itemList.Add(new Items("Divine Ruin", "images/items/DivineRuin.jpg", "Magical"));
            itemList.Add(new Items("Spear Of Desolation", "images/items/SpearOfDesolation.jpg", "Magical"));
            itemList.Add(new Items("Obsidian Shard", "images/items/ObsidianShard.jpg", "Magical"));
            itemList.Add(new Items("Spear Of The Magus", "images/items/SpearOfTheMagus.jpg", "Magical"));
            itemList.Add(new Items("Gem Of Isolation", "images/items/GemOfIsolation.jpg", "Magical"));
            itemList.Add(new Items("Warlock's Staff", "images/items/WarlocksStaff.jpg", "Magical"));
            itemList.Add(new Items("Ethereal Staff", "images/items/EtherealStaff.jpg", "Magical"));
            itemList.Add(new Items("Rod Of Asclepius", "images/items/RodOfAsclepius.jpg", "Magical"));
            itemList.Add(new Items("Book Of Thoth", "images/items/BookOfThoth.jpg", "Magical"));
            itemList.Add(new Items("Polynomicon", "images/items/Polynomicon.jpg", "Magical"));
            itemList.Add(new Items("Soul Reaver", "images/items/SoulReaver.jpg", "Magical"));
            itemList.Add(new Items("Book Of The Dead", "images/items/BookOfTheDead.jpg", "Magical"));
            itemList.Add(new Items("Rod Of Tahuti", "images/items/RodOfTahuti.jpg", "Maagical"));
            itemList.Add(new Items("Chronos' Pendant", "images/items/ChronosPendant.jpg", "Magical"));
            itemList.Add(new Items("Doom Orb", "images/items/DoomOrb.jpg", "Magical"));
            itemList.Add(new Items("Charon's Coin", "images/items/CharonsCoin.jpg", "Magical"));
            itemList.Add(new Items("Runic Shield", "images/items/RunicShield.jpg", "Physical"));
            itemList.Add(new Items("Ancile", "images/items/Ancile.jpg", "Physical"));
            itemList.Add(new Items("Caduceus Shield", "images/items/CaduceusShield.jpg", "Physical"));
            itemList.Add(new Items("Celestial Legion Helm", "images/items/CelestialLegionHelm.jpg", "Magical"));
            itemList.Add(new Items("Lotus Crown", "images/items/LotusCrown.jpg", "Magical"));
            itemList.Add(new Items("Jade Emperor's Crown", "images/items/JadeEmperorsCrown.jpg", "Magical"));
            itemList.Add(new Items("Tyrannical Plate Helm", "images/items/TyrannicalPlateHelm.jpg", "Magical"));
            itemList.Add(new Items("Odysseus' Bow", "images/items/OdysseusBow.jpg", "Physical"));
            itemList.Add(new Items("Ichaival", "images/items/Ichaival.jpg", "Physical"));
            itemList.Add(new Items("Silverbranch Bow", "images/items/SilverbranchBow.jpg", "Physical"));
            itemList.Add(new Items("Atalanta's Bow", "images/items/AtalantasBow.jpg", "Physical"));
            itemList.Add(new Items("Stone Of Gaia", "images/items/StoneOfGaia.jpg", "Global"));
            itemList.Add(new Items("Shield Of Regrowth", "images/items/ShieldOfRegrowth.jpg", "Global"));
            itemList.Add(new Items("Mail Of Renewal", "images/items/MailOfRenewal.jpg", "Global"));
            itemList.Add(new Items("Gauntlet Of Thebes", "images/items/GauntletOfThebes.jpg", "Global"));
            itemList.Add(new Items("Wind Demon", "images/items/WindDemon.jpg", "Physical"));
            itemList.Add(new Items("Poisoned Star", "images/items/PoisonedStar.jpg", "Physical"));
            itemList.Add(new Items("Stone Cutting Sword", "images/items/StoneCuttingSword.jpg", "Physical"));
            itemList.Add(new Items("Masamune", "images/items/Masamune.jpg", "Physical"));
            itemList.Add(new Items("Hastened Katana", "images/items/HastenedKatana.jpg", "Physical"));
            itemList.Add(new Items("Golden Blade", "images/items/GoldenBlade.jpg", "Physical"));
            itemList.Add(new Items("Genji's Guard", "images/items/GenjisGuard.jpg", "Global"));
            itemList.Add(new Items("Oni Hunter's Garb", "images/items/OniHuntersGarb.jpg", "Global"));
            itemList.Add(new Items("Shogun's Kusari", "images/items/ShogunsKusari.jpg", "Global"));
            itemList.Add(new Items("Acorn Of Yggdrasil", "images/items/AcornOfYggdrasil.jpg", "Unique"));
            itemList.Add(new Items("Void Stone", "images/items/VoidStone.jpg", "Magical"));
            itemList.Add(new Items("Stone Of Fal", "images/items/StoneOfFal.jpg", "Magical"));
            itemList.Add(new Items("Bumba's Mask", "images/items/BumbasMask.jpg", "Global"));
            itemList.Add(new Items("Rangda's Mask", "images/items/RangdasMask.jpg", "Unique"));
            itemList.Add(new Items("Lono's Mask", "images/items/LonosMask.jpg", "Unique"));
            itemList.Add(new Items("Staff Of Myrddin", "images/items/StaffOfMyrddin.jpg", "Magical"));
            itemList.Add(new Items("Pridwen", "images/items/Pridwen.jpg", "Global"));
            itemList.Add(new Items("Arondight", "images/items/Arondight.jpg", "Physical"));
            itemList.Add(new Items("Fail-not", "images/items/FailNot.jpg", "Physical"));
        }

        private void RoleFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            godNameLabel.Text = "God Name";
            godDescriptionLabel.Text = "God Description";
            godPictureBox.Image = null;
            item1PictureBox.Image = null;
            item2PictureBox.Image = null;
            item3PictureBox.Image = null;
            item4PictureBox.Image = null;
            item5PictureBox.Image = null;
            item6PictureBox.Image = null;
            selectedRole = roleFilterComboBox.SelectedItem.ToString();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            bool godVerified = false;
            bool hasMask = false;
            bool itemVerified;
            bool hasBoots = false;
            int uniqueItem = 0;
            int countTest = 0;
            int buildCompletion = 0;
            Random random = new Random();

            int randomGod = random.Next(107);
            List<int> randomizedItemList = new List<int>();
            Items item;

            Gods chosenGod = godList[randomGod];
            string damageType;

            while (godVerified != true)
            {
                if (chosenGod.Role.Equals(selectedRole) || selectedRole == "All")
                {
                    godVerified = true;
                }
                else
                {
                    randomGod = random.Next(107);
                    chosenGod = godList[randomGod];
                }
            }

            if(chosenGod.Role == "Warrior" || chosenGod.Role == "Hunter" || chosenGod.Role == "Assassin")
            {
                damageType = "Physical";
            }
            else
            {
                damageType = "Magical";
            }

            while (buildCompletion <= 5)
            {
                itemVerified = false;
                int randomItem = random.Next(107);
                countTest = 0;
                while (itemVerified != true)
                {
                    uniqueItem = 0;
                    if (buildCompletion == 0)
                    {
                        item = itemList[randomItem];
                        if (item.Type == "Unique")
                        {
                            if (item.Name == "Rangda's Mask")
                            {
                                if (randomGod == 81)
                                {
                                    hasBoots = true;
                                    randomItem = 97;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else if (chosenGod.Role == "Warrior" || chosenGod.Role == "Guardian")
                                {
                                    hasMask = true;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else
                                {
                                    randomItem = random.Next(107);
                                }
                            }
                            else if (item.Name == "Lono's Mask")
                            {
                                if (randomGod == 81)
                                {
                                    hasBoots = true;
                                    randomItem = 97;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else if (chosenGod.Role == "Hunter" || chosenGod.Role == "Assassin" || chosenGod.Role == "Mage")
                                {
                                    hasMask = true;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else
                                {
                                    randomItem = random.Next(107);
                                }
                            }
                            else
                            {
                                if (randomGod == 81)
                                {
                                    hasBoots = true;
                                    randomItem = 97;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else
                                {
                                    randomItem = random.Next(107);
                                }
                            }
                        }
                        else if (item.Type.Equals(damageType) || item.Type == "Global")
                        {
                            if (randomGod == 81)
                            {
                                hasBoots = true;
                                randomItem = 97;
                            }
                            if(randomItem == 100)
                            {
                                hasMask = true;
                            }
                            else if (randomItem >= 18 && randomItem <= 25)
                            {
                                hasBoots = true;
                            }
                            randomizedItemList.Add(randomItem);
                            itemVerified = true;
                        }
                        else
                        {
                            randomItem = random.Next(107);
                        }
                    }
                    else
                    {
                        while(uniqueItem < randomizedItemList.Count)
                        {
                            uniqueItem = 0;
                            for (int i = 0; i < randomizedItemList.Count; i++)
                            {
                                if (randomItem == randomizedItemList[i])
                                {
                                    //uniqueItem = false;
                                    randomItem = random.Next(107);
                                }
                                else if ((randomItem >= 18 && randomItem <= 25) && hasBoots == true)
                                {
                                    randomItem = random.Next(107);
                                }
                                else if(randomItem == 100 && hasMask == true)
                                {
                                    randomItem = random.Next(107);
                                }
                                else
                                {
                                    uniqueItem++;
                                    countTest++;
                                }
                            }
                        }


                        item = itemList[randomItem];
                        if (item.Type.Equals(damageType) || item.Type == "Global")
                        {
                            if (randomItem >= 18 && randomItem <= 25)
                            {
                                hasBoots = true;
                            }
                            else if(randomItem == 100)
                            {
                                hasMask = true;
                            }
                            randomizedItemList.Add(randomItem);
                            itemVerified = true;
                        }
                        else if (item.Type == "Unique")
                        {
                            if (item.Name == "Rangda's Mask")
                            {
                                if ((chosenGod.Role == "Warrior" || chosenGod.Role == "Guardian") && hasMask != true)
                                {
                                    hasMask = true;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else
                                {
                                    randomItem = random.Next(107);
                                }
                            }
                            else if (item.Name == "Lono's Mask")
                            {
                                if ((chosenGod.Role == "Hunter" || chosenGod.Role == "Assassin" || chosenGod.Role == "Mage") && hasMask != true)
                                {
                                    hasMask = true;
                                    randomizedItemList.Add(randomItem);
                                    itemVerified = true;
                                }
                                else
                                {
                                    randomItem = random.Next(107);
                                }
                            }
                            else
                            {
                                randomItem = random.Next(107);
                            }
                        }

                        else
                        {
                            randomItem = random.Next(107);
                        }
                    }
                }
                buildCompletion++;
            }

            godNameLabel.Text = chosenGod.Name;
            godDescriptionLabel.Text = chosenGod.Description;
            godPictureBox.Image = Image.FromFile(chosenGod.ImageSource);
            item1PictureBox.Image = Image.FromFile(itemList[randomizedItemList[0]].ImageSource);
            item2PictureBox.Image = Image.FromFile(itemList[randomizedItemList[1]].ImageSource);
            item3PictureBox.Image = Image.FromFile(itemList[randomizedItemList[2]].ImageSource);
            item4PictureBox.Image = Image.FromFile(itemList[randomizedItemList[3]].ImageSource);
            item5PictureBox.Image = Image.FromFile(itemList[randomizedItemList[4]].ImageSource);
            item6PictureBox.Image = Image.FromFile(itemList[randomizedItemList[5]].ImageSource);
        }
    }
}
