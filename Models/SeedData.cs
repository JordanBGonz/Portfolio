using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());
        
        if (context.Books.Any())
        {
            return;
        }
        Book bookOne = new()
        {
            ImageURL = "img/Nightingale.jpg",
            Title = "The Nightingale",
            Author = "Kristin Hannah",
            Description = "The Nightingale by Kristin Hannah is a historical fiction novel set in Nazi-occupied France during World War II. It tells the story of two sisters, Vianne and Isabelle Mauriac, who respond to the war in very different ways. Vianne, the elder, tries to protect her family and survive the occupation quietly, while Isabelle joins the French Resistance and risks her life helping Allied pilots escape. The novel explores themes of love, sacrifice, survival, and the resilience of women during wartime."
        };
        Book bookTwo = new()
        {
            ImageURL="img/neverknown.jpg", 
            Title = "I Who Have Never Known Men", 
            Author = "Jacqueline Harpman", 
            Description = "I Who Have Never Known Men by Jacqueline Harpman is a haunting dystopian novel about a young woman who grows up imprisoned in an underground bunker with thirty-nine older women. None of them know why they were taken or who their captors are. When the guards suddenly disappear, the women escape and try to survive in a barren, post-apocalyptic world. The story is told through the eyes of the youngest woman, who reflects on isolation, identity, memory, and what it means to be human in a world without men, history, or purpose."
        };
        Book bookThree = new()
        {
            ImageURL="img/inmate.jpg", 
            Title = "The Inmate", 
            Author = "Freida McFadden", 
            Description = "The Inmate by Freida McFadden is a psychological thriller about Brooke Sullivan, a nurse practitioner who starts working at a men’s maximum-security prison. There, she comes face to face with Shane Nelson — her former high school crush and the man convicted of murdering her best friend. As Brooke becomes entangled in her past and Shane insists he was wrongly accused, she begins to question what really happened. The story is full of twists and explores themes of memory, trust, and the danger of buried secrets."
        
        };
        Book bookFour = new()
        {
            ImageURL="img/tender.jpg",
            Title ="Tender is the Flesh", 
            Author = "Agustina Bazterrica", 
            Description = "Tender Is the Flesh by Agustina Bazterrica is a dystopian novel set in a world where a virus has made animal meat inedible, leading society to legalize the farming and consumption of human meat. The story follows Marcos, who works at a processing plant that prepares 'special meat'. Though he tries to emotionally detach from the horrors of his job, his perspective begins to shift when he’s given a live female specimen as a gift. The novel explores themes of dehumanization, morality, complicity, and the dark extremes of capitalism and survival."
        };
        Book bookFive = new()
        {
            ImageURL="img/maevefly.jpg",
            Title = "Maeve Fly", 
            Author ="CJ Leede", 
            Description="Maeve Fly by CJ Leede is a dark, horror-tinged psychological novel that follows Maeve, a seemingly cheerful woman who works as a princess character at a Los Angeles theme park. Beneath her sunny exterior, however, lies a much darker and violent nature. As her internal chaos grows and her grip on reality slips, Maeve spirals into a terrifying exploration of identity, obsession, and feminine rage. The novel blends horror, satire, and psychological depth, offering a chilling look at the monstrous beneath the mundane."
        };

        context.Books.AddRange(
            new Book {ImageURL="img/crawdads.jpg",Title = "Where the Crawdads Sing", Author ="Delia Owens", Description="Set in the marshes of North Carolina, this novel blends coming-of-age drama, romance, and a murder mystery as it follows 'Marsh Girl' Kya, an outcast whose connection to nature helps her survive abandonment and isolation."},
            new Book {ImageURL="img/midnight.jpg",Title = "The Midnight Library", Author ="Matt Haig", Description="Between life and death lies a library filled with books that show how your life could have gone differently. Nora Seed must explore alternate versions of her life to find the one worth living."},
            new Book {ImageURL="img/chemistry.jpg",Title = "Lessons in Chemistry", Author ="Bonnie Garmus", Description="Elizabeth Zott is a brilliant chemist navigating the 1960s male-dominated science world—until she becomes the star of a popular cooking show and inspires women to challenge societal norms."},
            new Book {ImageURL="img/tomorrow.jpg",Title = "Tomorrow, and Tomorrow, and Tomorrow", Author ="Gabrielle Zevin", Description="A beautifully written exploration of creativity, friendship, and ambition as two childhood friends reunite and build a successful video game empire, facing love, loss, and the pressures of fame."},
            new Book {ImageURL="img/silent.jpg",Title = "The Silent Patient", Author ="Alex Michaelides", Description="When a famous artist murders her husband and never speaks another word, a psychotherapist becomes obsessed with uncovering the truth behind her silence—and her crime."},
            new Book {ImageURL="img/verity.jpg",Title = "Verity", Author ="Colleen Hoover", Description="A struggling writer is hired to finish a best-selling author's series, only to find a chilling manuscript hidden in the house—one that suggests a horrifying truth behind a tragic family."},
            new Book {ImageURL="img/housemaid.jpg",Title = "The Housemaid", Author ="Freida McFadden", Description="Millie takes a job as a live-in maid for a wealthy family, but the rules are strict, and the wife is unhinged. As strange events unfold, Millie realizes she may be trapped in more ways than one."},
            new Book {ImageURL="img/gone.jpg",Title = "Gone Girl", Author ="Gillian Flynn", Description="On the morning of their fifth wedding anniversary, Amy Dunne disappears. As the media frenzy grows, suspicion turns to her husband Nick—and shocking secrets begin to unravel."},
            new Book {ImageURL="img/fourth.jpg",Title = "Fourth Wing", Author ="Rebecca Yarros", Description="In a world where dragons choose their riders, Violet Sorrengail is forced to join a deadly war college. With enemies all around and secrets lurking in every shadow, her survival depends on more than just skill."},
            new Book {ImageURL="img/atlas.jpg",Title = "The Atlas Six", Author ="Olivie Blake", Description="Six powerful magicians are recruited to join a secret society that guards lost knowledge. But only five will earn a place, and the price of admission might be betrayal—or worse."},
            new Book {ImageURL="img/roses.jpg",Title = "A Court of Thorns and Roses", Author ="Sarah J. Maas", Description="Feyre, a mortal huntress, is taken to a fae realm as punishment for killing a magical creature. There, she uncovers dark secrets, ancient curses, and a dangerous love that could change everything."},
            new Book {ImageURL="img/hailmary.jpg",Title = "Project Hail Mary", Author ="Andy Weir", Description="Ryland Grace wakes up alone on a spaceship, with no memory and only one mission: to save humanity. As he pieces together the past, he discovers help from the most unexpected source."},
            new Book {ImageURL="img/babel.jpg",Title = "Babel", Author ="R.F. Kuang", Description="A dark academic fantasy set in an alternate 1800s Oxford, where language holds magical power—and colonialism, revolution, and identity collide in a high-stakes battle for truth."},
            new Book {ImageURL="img/1984.jpg",Title = "1984", Author ="George Orwell", Description="A terrifying vision of a totalitarian regime where every thought is monitored and reality is rewritten. Orwell’s classic warns of the dangers of surveillance, propaganda, and authoritarian control."},
            new Book {ImageURL="img/power.jpg",Title = "The Power", Author ="Naomi Alderman", Description="Teenage girls around the world develop the ability to emit electrical energy—upending global gender power structures and forcing humanity to face what happens when roles are reversed."},
            new Book {ImageURL="img/withus.jpg",Title = "It Ends With Us", Author ="Colleen Hoover", Description="Lily falls for the charming Ryle, but when dark patterns from her past begin to echo in the present, she must make a heart-wrenching choice between love and self-respect."},
            new Book {ImageURL="img/meet.jpg",Title = "People We Meet on Vacation", Author ="Emily Henry", Description="Poppy and Alex, best friends with opposite personalities, used to take an annual vacation together—until something tore them apart. Now, they reunite for one last trip to see if they can fix what was broken."},
            new Book {ImageURL="img/seven.jpg",Title = "The Seven Husbands of Evelyn Hugo", Author ="Taylor Jenkins Reid", Description="Legendary Hollywood actress Evelyn Hugo recounts her glamorous, scandal-filled life—and the truth behind her seven marriages—to a young journalist, revealing a love story that changed everything."},
            new Book {ImageURL="img/shatter.jpg",Title = "Shatter Me", Author ="Tahereh Mafi", Description="Juliette’s touch is fatal. Imprisoned for her dangerous gift, she’s suddenly released into a dystopian world where she must choose between being a weapon or a warrior."},
            new Book {ImageURL="img/thief.jpg",Title = "The Book Thief", Author ="Markus Zusak", Description="Narrated by Death, this WWII novel follows a young girl in Nazi Germany who steals books to survive—and share hope—during a time of immense darkness."},
            new Book {ImageURL="img/paris.jpg",Title = "The Paris Library", Author ="Janet Skeslien Charles", Description="Based on a true story, this novel weaves together the lives of a librarian in Nazi-occupied Paris and a lonely girl in 1980s Montana, connected by love for books and resistance."},
            new Book {ImageURL="img/measure.jpg",Title = "The Measure", Author ="Nikki Erlick", Description="One day, every person on Earth receives a box with a string inside—revealing how long they will live. This thought-provoking novel explores fate, free will, and how we choose to live when time is limited."}

        );

        context.SaveChanges();
        
        bookFive.Reviews = new List<Review>(){
            new Review {
                Score = 4,
                ReviewText = "Maeve Fly is a bold, disturbing, and highly original horror novel that blends psychological tension with gruesome, visceral imagery. CJ Leede crafts a protagonist who is both compelling and deeply unsettling—Maeve is a woman on the edge, hiding her violent impulses behind the smiling mask of a theme park princess in Los Angeles. The setting, filled with artificial happiness and consumerism, provides the perfect backdrop for a story that interrogates identity, rage, grief, and the monstrous aspects of womanhood."
            }
        };

        bookOne.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "Kristin Hannah’s writing is emotional, immersive, and beautifully crafted. The novel delivers a powerful exploration of love, sacrifice, and the strength of women in the face of unimaginable hardship. It’s deeply moving, with well-drawn characters and a story that lingers long after the final page. A standout work of historical fiction that’s both heartbreaking and inspiring."
            }
        };
         bookOne.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "A beautifully written, emotionally charged novel that showcases Kristin Hannah's talent for capturing the human spirit. It's a tearjerker with depth, offering a nuanced portrayal of inner strength, loyalty, and sacrifice. This book will stay with you long after you finish."
            }
        };

        bookTwo.Reviews = new List<Review>(){
            new Review {
                Score = 4,
                ReviewText = "This novel is haunting, sparse, and deeply philosophical. Harpman explores isolation, identity, and what it means to be human with quiet intensity. The writing is minimalist but powerful, creating a sense of eerie detachment that mirrors the narrator’s experience. It’s a thought-provoking and emotionally resonant read that lingers long after finishing—bleak, beautiful, and unforgettable."
            }
        };
        bookTwo.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "A stark and haunting meditation on existence, this novel is quietly powerful. It reads almost like a philosophical thought experiment, lingering in its silences and unanswered questions. Minimalist and profound, it demands reflection more than action."
            }
        };

       bookFour.Reviews = new List<Review>(){
            new Review {
                Score = 4,
                ReviewText = "Brutal, thought-provoking, and deeply unsettling, this novel confronts readers with disturbing questions about morality, dehumanization, and the limits of societal normalization. Bazterrica’s writing is sharp and clinical, creating an atmosphere of emotional detachment that enhances the horror. It’s a bold, provocative read that forces uncomfortable reflection—intelligent, horrifying, and impossible to forget."
            }
        }; 
         bookFour.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "Disturbing in the best way, this book is a sharp critique of modern society wrapped in dystopian horror. Its cold, clinical tone makes the horror feel even more real. Not for the faint of heart, but unforgettable for those who can stomach it."
            }
        };


        bookThree.Reviews = new List<Review>(){
            new Review {
                Score = 4,
                ReviewText = "Fast-paced and filled with twists, this thriller keeps you guessing until the end. McFadden delivers sharp tension, unreliable characters, and plenty of suspense. While it leans into dramatic turns, it’s an entertaining and addictive read that’s perfect for fans of dark domestic thrillers. You’ll likely fly through it in one sitting."
            }
        }; 
         bookThree.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "A twisty, addictive psychological thriller that delivers the shocks you expect—and a few you won’t. It’s a quick, engaging read with high drama and tension throughout. While not always subtle, it’s undeniably entertaining."
            }
        };

        bookFive.Reviews = new List<Review>(){
            new Review {
                Score = 5,
                ReviewText = "Dark, daring, and unapologetically grotesque, Maeve Fly is a fearless exploration of identity, rage, and the monstrous feminine. Leede blends horror with literary flair, crafting a narrative that’s both shocking and strangely poetic. It’s bold, polarizing, and unforgettable—a gut-punch of a debut."
            }
        };

        context.Add(bookOne);
        context.Add(bookTwo);
        context.Add(bookThree);
        context.Add(bookFour);
        context.Add(bookFive);

        context.SaveChanges();
    }
}